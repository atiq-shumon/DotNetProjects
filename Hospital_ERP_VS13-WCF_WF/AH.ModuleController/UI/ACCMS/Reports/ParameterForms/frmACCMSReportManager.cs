using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmACCMSReportManager()
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

        private void frmACCMSReportManager_Load(object sender, EventArgs e)
        {
            dtStartDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtEndDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            rdoCollectionDetails.Checked = true;
            cboDateType.SelectedIndex = 0;
        }

        public bool checkradio()
        {
            RadioButton[] radioButtons = new RadioButton[] { rdoCollectionDetails, rdoCollectionSummary };
            if (!radioButtons.Any(rb => rb.Checked))
            {
                return false;
            }
            return true;
        }

        public void MakeSQLDateCondition()
        {
            if (TxtSearchCondition == "")
            {
                #region SearchwithOnlyDate

                DateCondition = " where " + DateFieldName + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

                #endregion
            }
            if (TxtSearchCondition != "")
            {

                #region searchwithOtherParamiter

                DateCondition = " and " + DateFieldName + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

                #endregion
            }
        }

        public void ColDetailsACCMS()
        {
            frmReportViewer ofrmReportViewerACCMS = new frmReportViewer();
            ofrmReportViewerACCMS.selector = ViewerSelector.CollectionDetails;
            ofrmReportViewerACCMS.WhereCondition = DateCondition;
            ofrmReportViewerACCMS.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerACCMS.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerACCMS.ReportSecondParameter = ofrmReportViewerACCMS.GetDateRange();
            ofrmReportViewerACCMS.ViewReport();
        }

        public void ColSummaryACCMS()
        {
            frmReportViewer ofrmReportViewerACCMS = new frmReportViewer();
            ofrmReportViewerACCMS.selector = ViewerSelector.CollectionSummary;
            ofrmReportViewerACCMS.WhereCondition = DateCondition;
            ofrmReportViewerACCMS.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerACCMS.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerACCMS.ReportSecondParameter = ofrmReportViewerACCMS.GetDateRange();
            ofrmReportViewerACCMS.ViewReport();
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
            if (rdoCollectionDetails.Checked == true)
            {
                if (dtStartDate.Text != "" && dtEndDate.Text != "")
                {
                    DateFieldName = "";
                    DateFieldName = "TransactionDate";
                    DateOptionMake = "between";

                }

                if (dtStartDate.Text == "" || dtEndDate.Text == "")
                {
                    MessageBox.Show("Provide Date for Report Content");
                    return;
                }
                MakeSQLDateCondition();
                ColDetailsACCMS();
            }
            if (rdoCollectionSummary.Checked == true)
            {
                if (dtStartDate.Text != "" && dtEndDate.Text != "")
                {
                    DateFieldName = "";
                    DateFieldName = "TransactionDate";
                    DateOptionMake = "between";

                }

                if (dtStartDate.Text == "" || dtEndDate.Text == "")
                {
                    MessageBox.Show("Provide Date for Report Content");
                    return;
                }
                MakeDateandGropby();
                ColSummaryACCMS();
            }
        }

        public void MakeDateandGropby()
        {
            DateCondition = " where " + DateFieldName + " " + DateOptionMake + "  to_date('" + dtStartDate.Text +
                                "','dd/MM/yyyy'" + ") and to_date('" + dtEndDate.Text + "','dd/MM/yyyy'" + ") ";

            DateCondition = DateCondition + "" + "group by ColSumm.purpose_id,ColSumm.Purpose_Title";
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
    }
}
