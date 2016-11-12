using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.PatientRegistration.Reports.Viewer;

namespace AH.ModuleController.UI.PatientRegistration.ParameterForms
{
    public partial class frmPetRegReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmPetRegReportManager()
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
        public string HCNReturn { set; get; }
        #endregion
        private void rdoPetReg_CheckedChanged(object sender, EventArgs e)
        {

            lblParam1.Text = "HCN";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Text = string.Empty;
            txtParam1.Select();
            gbInformationControlls.Visible = true;
            gbDateRange.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;

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
        public void MakeSQLDateCondition()
        {
            if (TxtSearchCondition == "")
            {
                #region SearchwithOnlyDate

                //DateCondition = " where " + DateFieldName + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                //                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

                DateCondition = " where " + "to_date(to_char(" + DateFieldName + ",'dd/MM/yyyy'),'dd/MM/yyyy')" + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

                #endregion
            }
            if (TxtSearchCondition != "")
            {

                #region searchwithOtherParamiter

                //DateCondition = " and " + DateFieldName + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                //                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

                DateCondition = " and " + "to_date(to_char(" + DateFieldName + ",'dd/MM/yyyy'),'dd/MM/yyyy')" + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

                #endregion
            }
        }
        public void CheckDateOPtions()
        {

            DateTime startdate = Convert.ToDateTime(dtStartDate.Text);
            DateTime enddate = Convert.ToDateTime(dtEndDate.Text);
            if (startdate <= enddate)
            {
                DateOptionMake = "Between";
            }
            if (startdate > enddate)
            {
                MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
            }
            MakeSQLDateCondition();

        }
        public void CheckTxtSearchOPtions()
        {
            if (txtParam1.Text != "")
            {
                TxtSearchCondition = " Where  " + FieldName + "='" + txtParam1.Text.ToString().ToUpper() + "'";
            }
        }
        public void MakeSQL()
        {
            FieldName = "View_Pat_Reg_Details.HCN";
            DateFieldName = "View_Pat_Reg_Details.ENTRYDATE";
            if (rdoPetReg.Checked == true)
            {
                CheckTxtSearchOPtions();
            }
            if (rdoDateRange.Checked == true)
            {
                CheckDateOPtions();
            }
            FinalWhereCondition = TxtSearchCondition + DateCondition;
        }
        public bool ValidateSearchData()
        {
            MakeSQL();
            return true;
        }
        public void PatientRegistrationDetailsbyHCN()
        {
            frmReportViewer ofrmReportViewerPetReg = new frmReportViewer();
            ofrmReportViewerPetReg.selector = ViewerSelector.PetRegDetailsbyHCN;
            ofrmReportViewerPetReg.WhereCondition = FinalWhereCondition;
            ofrmReportViewerPetReg.ViewReport();
        }

        public void PatientRegistrationDetailsbyDateRange()
        {
            frmReportViewer ofrmReportViewerPetReg = new frmReportViewer();
            ofrmReportViewerPetReg.selector = ViewerSelector.PetRegDetailsbyDateRange;
            ofrmReportViewerPetReg.WhereCondition = FinalWhereCondition;
            ofrmReportViewerPetReg.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerPetReg.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerPetReg.ReportSecondParameter = ofrmReportViewerPetReg.GetDateRange();
            ofrmReportViewerPetReg.ViewReport();
        }

        public bool checkradio()
        {
            RadioButton[] radioButtons = new RadioButton[] { rdoPetReg, rdoDateRange, rdoHealthCard };
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
            ValidateSearchData();
            if (rdoPetReg.Checked == true)
            {
                if (txtParam1.Text != "")
                {
                    txtParam1.Text = txtParam1.Text.ToUpper();
                    PatientRegistrationDetailsbyHCN();
                }
                else
                {
                    MessageBox.Show("Please provide the HCN number");
                }
            }
            if (rdoDateRange.Checked == true)
            {
                PatientRegistrationDetailsbyDateRange();
            }
            if (rdoHealthCard.Checked == true)
            {
                txtParam1.Enabled = true;
                if (txtParam1.Text != "")
                {
                    txtParam1.Text = txtParam1.Text.ToUpper();
                    PatientHealthCard();
                }
                else
                {
                    MessageBox.Show("Please provide the HCN number");
                }
            }
        }

        private void PatientHealthCard()
        {
            frmReportViewer ofrmReportViewerPetReg = new frmReportViewer();
            ofrmReportViewerPetReg.selector = ViewerSelector.PatientCard;
            ofrmReportViewerPetReg.PatientNo = txtParam1.Text;
            ofrmReportViewerPetReg.ReportTitle = "AH Health Card";
            ofrmReportViewerPetReg.ViewReport();
        }

        private void ReturnedData(string returnString, Object sender, EventArgs e)
        {
            txtParam1.Text = returnString;
        }

        private void cboParam1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smartRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbInformationControlls.Enabled = false;
            gbDateRange.Enabled = true;
            txtParam1.Text = "";
            HCNReturn = "";
            cboDateType.Select();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CheckParameter()
        {
            if (HCNReturn != "" && HCNReturn != null)
            {
                txtParam1.Text = HCNReturn;
                rdoPetReg.Checked = true;
            }
            else
            {
                txtParam1.Text = "";
                rdoPetReg.Checked = false;
                rdoDateRange.Checked = false;
            }
            lblParam1.Text = "HCN";
        }

        private void frmPetRegReportManager_Load(object sender, EventArgs e)
        {
            dtStartDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtEndDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            //CheckParameter();
            gbReportOption.Visible = true;
            gbDateRange.Visible = false;
            gbInformationControlls.Visible = false;
            rdoHealthCard.Checked = true;

            //if (HCNReturn != "" && HCNReturn != null)
            //{
            //    gbInformationControlls.Visible = true;
            //}
            //if (HCNReturn == "" || HCNReturn == null)
            //{
            //    gbInformationControlls.Visible = false;
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdoHealthCard_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "HCN";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Text = string.Empty;
            txtParam1.Select();
            gbInformationControlls.Visible = true;
            gbDateRange.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;
        }

        private void txtParam1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtParam1.Text.ToUpper().Length == Utility.ScanLength)
            {
                txtParam1.Text = txtParam1.Text.ToUpper();
            }
        }
    }
}
