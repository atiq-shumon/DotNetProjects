using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.OPD.Reports.Viewer;
using System.Linq;
using AH.ModuleController.OPDSR;


namespace AH.ModuleController.UI.OPD.Reports.ParameterForms
{
    public partial class frmReportOPDCollection : AH.Shared.UI.frmSmartFormReportStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        string FinalWhereCondition = "";
        public frmReportOPDCollection()
        {
            InitializeComponent();
        }

        private void rdoMRCollectionDetails_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "HCN";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Enabled = false;
            txtParam1.BackColor = Color.Silver;
            txtParam1.ReadOnly = false;
            cboDepartment.Enabled = false;
            cboUnit.Enabled = false;
            cboDoctor.Enabled = false;

            cboDateType.Enabled = true;
            dtStartDate.Enabled = true;
            dtEndDate.Enabled = true;
            cboDateType.Select();
        }

        private void rdoDepNDoct_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Select Options";
            txtParam1.Enabled = false;
            txtParam1.BackColor = Color.Silver;
            txtParam1.ReadOnly = false;
            cboDepartment.Enabled = true;
            cboUnit.Enabled = true;
            cboDoctor.Enabled = false;
            cboUnit.Enabled = false;

            cboDateType.Enabled = true;
            dtStartDate.Enabled = true;
            dtEndDate.Enabled = true;
            cboDepartment.Focus();
        }

        private void rdoDep_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Select Options";
            txtParam1.Enabled = false;
            txtParam1.BackColor = Color.Silver;
            txtParam1.ReadOnly = false;
            cboDepartment.Enabled = true;
            cboUnit.Enabled = true;
            cboDoctor.Enabled = false;
            cboUnit.Enabled = false;

            cboDateType.Enabled = true;
            dtStartDate.Enabled = true;
            dtEndDate.Enabled = true;
            cboDepartment.Focus();
        }

        private void rdoVoucher_CheckedChanged(object sender, EventArgs e)
        {
            txtParam1.Text = "";
            txtParam1.Focus();
            lblParam1.Text = "User ID";
            smartlabel.Visible = true;
            txtParam1.Visible = true;
            txtParam1.ReadOnly = true;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            txtParam1.Text = ep.EntryBy;
            txtParam1.Enabled = true;
            txtParam1.BackColor = Color.White;

            cboDepartment.Enabled = false;
            cboUnit.Enabled = false;
            cboDoctor.Enabled = false;

            cboDateType.Enabled = true;
            dtStartDate.Enabled = true;
            dtEndDate.Enabled = true;
        }

        private void rdoCollectionDoctor_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Press View";
            txtParam1.Enabled = false;
            txtParam1.BackColor = Color.Silver;
            cboDepartment.Enabled = false;
            cboUnit.Enabled = false;
            cboDoctor.Enabled = false;
            txtParam1.ReadOnly = false;
            cboDateType.Enabled = false;
            dtStartDate.Enabled = false;
            dtEndDate.Enabled = false;

            cboDoctor.Focus();
        }

        private void rdoDoctorConsFee_CheckedChanged(object sender, EventArgs e) // individual collection of doctors
        {
            lblParam1.Text = "Select Options";
            txtParam1.Enabled = false;
            txtParam1.BackColor = Color.Silver;
            cboDepartment.Enabled = true;
            cboUnit.Enabled = true;
            cboDoctor.Enabled = true;
            txtParam1.ReadOnly = false;
            cboDateType.Enabled = true;
            dtStartDate.Enabled = true;
            dtEndDate.Enabled = true;

            cboDepartment.Select();
        }


        public bool checkradio()
        {
            RadioButton[] radioButtons = new RadioButton[] { rdoMRCollectionDetails, rdoDep, rdoCollectionDoctor, rdoDoctorConsFee, rdoVoucher, rdoDepNDoct };   //rdoOPDDoctor
            if (!radioButtons.Any(rb => rb.Checked))
            {
                return false;
            }
            return true;
        }

        public bool CheckDateOPtions()
        {
            if (cboDateType.Text != "")
            {
                if (cboDateType.Text != "None" && cboDateType.Text != "")
                {
                    DateTime startdate = DateTime.Parse(dtStartDate.Text);
                    DateTime enddate = DateTime.Parse(dtEndDate.Text);
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

        public void OPDDepatment()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();

            ofrmReportViewerOPD.selector = ViewerSelector.OPDDepartment;
            ofrmReportViewerOPD.WhereCondition = FinalWhereCondition;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);

            ofrmReportViewerOPD.ParamField = cboDepartment.Text;
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);

            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }
        public void OPDDepatmentNDoctor()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();

            ofrmReportViewerOPD.selector = ViewerSelector.OPDDepatmentNDoctorsFee;
            ofrmReportViewerOPD.WhereCondition = FinalWhereCondition;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);

            ofrmReportViewerOPD.ParamField = cboDepartment.Text;
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);

            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }
        public void OPDVoucher()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDVoucher;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }

        public void OPDCollectionDoctor()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDCollectionDoctor;

            ofrmReportViewerOPD.ParamField = txtParam1.Text;
            ofrmReportViewerOPD.ViewReport();
        }
        public void OPDDoctorConsFee()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDDoctorConsFee;
            ofrmReportViewerOPD.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerOPD.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerOPD.ParamField = cboDoctor.SelectedValue.ToString();
            ofrmReportViewerOPD.ParamField2 = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerOPD.ParamDateFrom = Convert.ToString(dtStartDate.Text);
            ofrmReportViewerOPD.ParamDateTo = Convert.ToString(dtEndDate.Text);
            ofrmReportViewerOPD.ReportSecondParameter = ofrmReportViewerOPD.GetDateRange();
            ofrmReportViewerOPD.ViewReport();
        }
        


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!checkradio())
            {
                MessageBox.Show("Select any report option");
                return;
            }

            if (rdoCollectionDoctor.Checked == true)
            {
                txtParam1.Enabled = false;
                txtParam1.BackColor = Color.Silver;
                OPDCollectionDoctor();
            }

            if (rdoMRCollectionDetails.Checked == true)
            {
                txtParam1.Enabled = false;
                txtParam1.BackColor = Color.Silver;
                if (!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDMRCollectionDetails();
            }

            if (rdoDep.Checked == true)
            {
                if (cboDepartment.SelectedValue != null || cboDepartment.SelectedValue != "")
                {
                    txtParam1.Enabled = false;
                    txtParam1.BackColor = Color.Silver;
                    if (cboDepartment.Text == "" || cboDepartment.Text == "--Select--")
                    {
                        MessageBox.Show("Provide Search Content");
                        cboDepartment.Focus();
                        return;
                    }

                    if (!CheckDateOPtions())
                    {
                        MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                        return;
                    }
                    OPDDepatment();

                }
                else
                {
                    MessageBox.Show("Provide Doctor's Name");
                }
            }

            if (rdoDepNDoct.Checked == true)
            {
                if (cboDepartment.SelectedValue != null || cboDepartment.SelectedValue != "")
                {
                    txtParam1.Enabled = false;
                    txtParam1.BackColor = Color.Silver;
                    if (cboDepartment.Text == "" || cboDepartment.Text == "--Select--")
                    {
                        MessageBox.Show("Provide Search Content");
                        cboDepartment.Focus();
                        return;
                    }

                    if (!CheckDateOPtions())
                    {
                        MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                        return;
                    }
                    OPDDepatmentNDoctor();

                }
                else
                {
                    MessageBox.Show("Provide Doctor's Name");
                }
            }

            if (rdoVoucher.Checked == true)
            {
                txtParam1.Enabled = false;
                txtParam1.BackColor = Color.Silver;
                if (!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDVoucher();
            }


            if (rdoCollectionDoctor.Checked == true)
            {
                txtParam1.Enabled = false;
                txtParam1.BackColor = Color.Silver;
             
                if (!CheckDateOPtions())
                {
                    MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                    return;
                }
                OPDCollectionDoctor();
            }

            if (rdoDoctorConsFee.Checked == true)
            {
                if (cboDoctor.SelectedValue != null)
                {
                    txtParam1.Enabled = false;
                    txtParam1.BackColor = Color.Silver;
                   
                    if (!CheckDateOPtions())
                    {
                        MessageBox.Show("End Date Can not be Greater Then Start Date!! Provide Appropriate Date");
                        return;
                    }
                    OPDDoctorConsFee();
                }
                else
                {
                    MessageBox.Show("Please Provide Doctor's Name");
                }
            }
        }

        private void frmOPDCollection_Load(object sender, EventArgs e)
        {
            dtStartDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtEndDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            rdoMRCollectionDetails.Checked = true;
            cboDateType.SelectedIndex = 0;

            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                GetOPDUnit();
            }
            else
            {
                return;
            } 
        }
        private void GetOPDUnit()
        {
            cboUnit.DisplayMember = "Value";
            cboUnit.ValueMember = "Key";
            cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOPDDoctor();
        }
        private void GetOPDDoctor()
        {
            cboDoctor.DisplayMember = "Value";
            cboDoctor.ValueMember = "Key";
            cboDoctor.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetOPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString())), null);
        }

        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

            if (cboDateType.Text == "Provide Date")
            {
                DateTime _dFrom = _dateTo.AddDays(0);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;
            }
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
