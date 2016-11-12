using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.OPD.Reports.Viewer;

namespace AH.ModuleController.UI.OPD.Reports.ParameterForms
{
    public partial class frmOPDReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmOPDReportManager()
        {
            InitializeComponent();
        }
        #region Declaration
        string TxtSearchCondition = "";
        string DateCondition = "";
        string FinalWhereCondition = "";
        string FieldName = "";
        string DateOptionMake = "";
        string DateFieldName = "";
        public string valuereturn { set; get; }
        public string valuereturn2 { set; get; }        
        #endregion
        private void rdoTicketDetails_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "HCN";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            btnSearch.Visible = false;
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbDateRange.Enabled = true;
            gbInformationControlls.Enabled = true;
            btnSearch.Visible = true;
            valuereturn = "";
            txtParam1.Text = "";
            gbInformationControlls.Enabled = false;
            cboDateType.SelectedIndex = 0;
            cboDateType.Focus();

        }
        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

            if (cboDateType.Text == "Last One Month")
            {
                DateTime _dFrom = _dateTo.AddDays(-30);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Three Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-3);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Six Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-6);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Year")
            {
                DateTime _dFrom = _dateTo.AddYears(-1);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            #endregion
        }
        public bool CheckDateOPtions()
        {
            if (cboDateType.Text != "")
            {
                if (cboDateType.Text != "None" && cboDateType.Text != "")
                {
                    DateTime startdate = Convert.ToDateTime(dtStartDate.Text);
                    DateTime enddate = Convert.ToDateTime(dtEndDate.Text);
                    if (startdate > enddate)
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
        public void OPDMRCollectionDetails()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDMRCollections;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerOPD.ReportTitle = "";
            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewerOPD.ViewReport();
        }

        public void OPDDrRoomAllRO()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDCollectionDoctor;
            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ViewReport();
        }

        public void OPDNurRoomAllRO()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDNurRoomAlloc;
            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ViewReport();
        }

        public void SearchMR()
        {
            if (txtParam1.Text != "")
            {
                TxtSearchCondition = " Where  " + FieldName + "='" + txtParam1.Text.ToString() + "'";
            }
        }
        public void SearchPrescription()
        {
            if (txtParam1.Text != "")
            {
                TxtSearchCondition = " where  " + FieldName + "='" + txtParam1.Text.ToString() + "'";
            }
        }
        public void OPDMR()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDMR;
            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ViewReport();
        }
        public void OPDPrescription()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDPrescription;
            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ViewReport();
        }

        public void OPDDepatment()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDDepartment;
            ofrmReportViewerOPD.WhereCondition = FinalWhereCondition;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);

            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);

            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }

        public void OPDDoctor()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDCollectionDoctor;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);

            ofrmReportViewerOPD.ParamField = doctorid;
            ofrmReportViewerOPD.ParamField2 = department;
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);

            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }
        public void OPDDoctorList()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.HRDoctorList;
            ofrmReportViewerOPD.WhereCondition = FinalWhereCondition;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }
        public void OPDDrCons()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDDoctorConsFee;
            ofrmReportViewerOPD.WhereCondition = TxtSearchCondition;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);

            ofrmReportViewerOPD.ParamField = doctorid;
            ofrmReportViewerOPD.ParamField2 = department;
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);

            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }
        public bool checkradio()
        {
            RadioButton[] radioButtons = new RadioButton[] { rdoMR, rdoMRCollectionDetails, rdoPrescription, rdoDep, rdoDoctor, rdoDoctorCons, rdoOPDDoctor, rdoOPDNurRomAlloc };
            if (!radioButtons.Any(rb => rb.Checked))
            {
                return false;
            }
            return true;
        }

 

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!checkradio())
            {
                MessageBox.Show("Select any report option");
                return;
            }
            TxtSearchCondition = "";
            DateCondition = "";

            if (rdoOPDDoctor.Checked == true)
            {
                
                OPDDrRoomAllRO();
            }

            if (rdoOPDNurRomAlloc.Checked == true)
            {

                OPDNurRoomAllRO();
            }

            if(rdoMRCollectionDetails.Checked ==true)
            {
                //if (cboDateType.SelectedIndex == 0)
                //{
                //    MessageBox.Show("Provide Date");
                //    cboDateType.Focus();
                //    return;
                //}
                if(!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDMRCollectionDetails();
            }

            if(rdoMR.Checked ==true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                OPDMR();
            }

            if ( rdoPrescription.Checked == true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                OPDPrescription();
            }

            if (rdoDep.Checked == true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                //if (cboDateType.SelectedIndex == 0)
                //{
                //    MessageBox.Show("Provide Date");
                //    cboDateType.Focus();
                //    return;
                //}
                if (!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDDepatment();
            }


            if (rdoDoctor.Checked == true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                //if (cboDateType.SelectedIndex == 0)
                //{
                //    MessageBox.Show("Provide Date");
                //    cboDateType.Focus();
                //    return;
                //}
                if (!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDDoctor();
            }
            

            if (rdoDoctorCons.Checked == true)
            {
                FieldName = "";
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                //if (cboDateType.SelectedIndex == 0)
                //{
                //    MessageBox.Show("Provide Date");
                //    cboDateType.Focus();
                //    return;
                //}
                if (!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDDrCons();
            }

        }
        private void frmOPDReportManager_Load(object sender, EventArgs e)
        {
            dtStartDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtEndDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            //rdoMR.Checked = true;
            cboDateType.SelectedIndex=0;
        }
        private void rdoMR_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Money Receipt No";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            btnSearch.Visible = true;
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;
            valuereturn = "";
            txtParam1.Text = "";
            cboDateType.SelectedIndex = 0;
            txtParam1.Focus();
        }
        string department = "";
        private string doctorid = "";

        private void ReturnedData(string returnString, Object sender, EventArgs e)
        {
            if(rdoDoctor.Checked ==true)
            {
                string doctor = returnString.Split(',')[0];
                department = returnString.Split(',')[1];
                 doctorid = returnString.Split(',')[2];
                txtParam1.Text = doctor;
            }

            if (rdoDoctor.Checked == false && rdoDoctorCons.Checked==false)
            {
                txtParam1.Text = returnString;
            }

            if (rdoDoctorCons.Checked == true)
            {
                string doctor = returnString.Split(',')[0];
                department = returnString.Split(',')[1];
                doctorid = returnString.Split(',')[2];
                txtParam1.Text = doctor;
            }

            //if (rdoDoctorCons.Checked == false)
            //{
            //    txtParam1.Text = returnString;
            //}
        }

        private void rdoPrescription_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Prescription No";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            btnSearch.Visible = true;
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;
            valuereturn = "";
            txtParam1.Text = "";
            cboDateType.SelectedIndex = 0;
            txtParam1.Focus();
        }

        private void GoToFind ()
        {
            string gridFor = "";
            if (txtParam1.Text != "")
            {
                txtParam1.Focus();
                return;
            }
              if(txtParam1.Text =="")
              {
                  if (rdoMRCollectionDetails.Checked == true)
                {
                    gridFor = "AllDetails";
                    frmOPDSearch frm = new frmOPDSearch();
                    frm.ReportCrieteria = gridFor;
                    frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    frm.ShowDialog();
                }
                  if (rdoMR.Checked == true)
                {
                    gridFor = "MoneyReceipt";
                    frmOPDSearch frm = new frmOPDSearch();
                    frm.ReportCrieteria = gridFor;
                    frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    frm.ShowDialog();
                }
                if (rdoPrescription.Checked == true)
                {
                    gridFor = "Prescription";
                    frmOPDSearch frm = new frmOPDSearch();
                    frm.ReportCrieteria = gridFor;
                    frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    frm.ShowDialog();
                }
                if (rdoDep.Checked == true)
                {
                    gridFor = "Department";
                    frmOPDSearch frm = new frmOPDSearch();
                    frm.ReportCrieteria = gridFor;
                    frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    frm.ShowDialog();
                }
                if (rdoDoctor.Checked == true)
                {
                    gridFor = "Doctor";
                    frmOPDSearch frm = new frmOPDSearch();
                    frm.ReportCrieteria = gridFor;
                    frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    frm.ShowDialog();
                }
                if (rdoDoctorCons.Checked == true)
                {
                    gridFor = "Doctor";
                    frmOPDSearch frm = new frmOPDSearch();
                    frm.ReportCrieteria = gridFor;
                    frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    frm.ShowDialog();
                }
                   cboDateType.Focus();
              }
            
        }
        private void rdoDep_CheckedChanged(object sender, EventArgs e)
        {
            department = "";
            doctorid = "";
            lblParam1.Text = "Department";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            btnSearch.Visible = true;
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbDateRange.Enabled = true;
            gbInformationControlls.Enabled = true;
            valuereturn = "";
            txtParam1.Text = "";
            cboDateType.SelectedIndex = 0;
            txtParam1.Focus();
        }
        private void rdoDoctor_CheckedChanged(object sender, EventArgs e)
        {
            doctorid = "";
            department = "";
            lblParam1.Text = "Doctor Name";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Enabled = false;
            btnSearch.Visible = true;
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbDateRange.Enabled = true;
            gbInformationControlls.Enabled = true;
            valuereturn = "";
            txtParam1.Text = "";
            cboDateType.SelectedIndex = 0;
            txtParam1.Focus();
        }

        private void rdoDoctorCons_CheckedChanged(object sender, EventArgs e)
        {
            doctorid = "";
            department = "";
            lblParam1.Text = "Doctor Name";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            btnSearch.Visible = true;
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbDateRange.Enabled = true;
            gbInformationControlls.Enabled = true;
            valuereturn = "";
            txtParam1.Text = "";
            cboDateType.SelectedIndex = 0;
            txtParam1.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GoToFind();
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoToFind();
            }
        }

        private void txtParam1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

        private void cboDateType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtStartDate.Focus();
            }
        }

        private void dtStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtEndDate.Focus();
            }
        }

        private void dtEndDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrint.Focus();
            }
        }

        //private void rdoDrRoomAllocation_CheckedChanged(object sender, EventArgs e)
        //{
        //    gbDateRange.Enabled = false;
        //    gbInformationControlls.Enabled = false;
        //}

        private void rdoOPDNurRomAlloc_CheckedChanged(object sender, EventArgs e)
        {
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = false;
        }

        private void dtStartDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rdoOPDDoctor_CheckedChanged(object sender, EventArgs e)
        {
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = false;
        }
       
    }
}
