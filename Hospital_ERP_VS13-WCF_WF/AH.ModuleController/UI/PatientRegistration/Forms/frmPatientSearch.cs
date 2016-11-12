using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.PatientRegistrationSR;
 

namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    public partial class frmPatientSearch : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmPatientSearch()
        {
            InitializeComponent();
        }
        PatientRegistrationSR.PatientRegistrationWSClient clnt = new PatientRegistrationWSClient();
        
       public delegate void PrintButtonClick(string returnString, Object sender, EventArgs e);
        public PrintButtonClick onPrintButtonClicked;
        private string PatName = "";
        private string PatMobile = "";
        private string PatDOB = "";
        private string PatFather = "";
        private string PatMother = "";
        private string PatSpouse = "";
        private string PatAdress = "";
        private string wherecondition = "";

       

        private void frmPatientSearch_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            
            //RefreshListView();
        }
        
        public void StyleDataGrid()
        {
            #region ColumnSize
            dgvPatientSearch.Columns["HCN"].Width = 130;
            dgvPatientSearch.Columns["PatientName"].Width = 130;
            dgvPatientSearch.Columns["FatherName"].Width = 130;
            dgvPatientSearch.Columns["MotherName"].Width = 130;
            dgvPatientSearch.Columns["SpouseName"].Width = 130;
            dgvPatientSearch.Columns["DateofBirth"].Width = 100;
            dgvPatientSearch.Columns["MobileNo"].Width = 130;
            dgvPatientSearch.Columns["Address"].Width = 200;
            #endregion
            #region ColumnVisibility
            dgvPatientSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dgvPatientSearch.EnableHeadersVisualStyles = false;
            dgvPatientSearch.Columns["category_id"].Visible = false;
            dgvPatientSearch.Columns["corporate_id"].Visible = false;
            dgvPatientSearch.Columns["staff_id"].Visible = false;
            dgvPatientSearch.Columns["e_rel_with_pat"].Visible = false;
            dgvPatientSearch.Columns["e_home_phone"].Visible = false;
            dgvPatientSearch.Columns["e_cell_phone"].Visible = false;
            dgvPatientSearch.Columns["e_address_beng"].Visible = false;
            dgvPatientSearch.Columns["e_address"].Visible = false;
            dgvPatientSearch.Columns["e_cont_person_beng"].Visible = false;
            dgvPatientSearch.Columns["e_cont_person"].Visible = false;
            dgvPatientSearch.Columns["per_district_code"].Visible = false;
            dgvPatientSearch.Columns["per_thana_code"].Visible = false;
            dgvPatientSearch.Columns["per_post_code"].Visible = false;
            dgvPatientSearch.Columns["per_ho_vi_ar_rd"].Visible = false;
            dgvPatientSearch.Columns["district_code"].Visible = false;
            dgvPatientSearch.Columns["thana_code"].Visible = false;
            dgvPatientSearch.Columns["post_code"].Visible = false;
            dgvPatientSearch.Columns["ho_vi_ar_rd_beng"].Visible = false;
            dgvPatientSearch.Columns["EducationLevel"].Visible = false;
            dgvPatientSearch.Columns["Occupation"].Visible = false;
            dgvPatientSearch.Columns["IncomeGroup"].Visible = false;
            dgvPatientSearch.Columns["YearlyIncome"].Visible = false;
            dgvPatientSearch.Columns["NID"].Visible = false;
            dgvPatientSearch.Columns["Email"].Visible = false;
            dgvPatientSearch.Columns["fname_beng"].Visible = false;
            dgvPatientSearch.Columns["mname_beng"].Visible = false;
            dgvPatientSearch.Columns["spouse_name_beng"].Visible = false;
            dgvPatientSearch.Columns["pat_name_beng"].Visible = false;
            dgvPatientSearch.Columns["guardian_name_beng"].Visible = false;
            dgvPatientSearch.Columns["FatherName"].Visible = false;
            dgvPatientSearch.Columns["MotherName"].Visible = false;
            dgvPatientSearch.Columns["SpouseName"].Visible = false;
            dgvPatientSearch.Columns["GuardianName"].Visible = false;
            dgvPatientSearch.Columns["RelationshipGuardian"].Visible = false;
            dgvPatientSearch.Columns["Religion"].Visible = false;
            dgvPatientSearch.Columns["BloodGroup"].Visible = false;
            dgvPatientSearch.Columns["MobileNo"].Visible = false;
            dgvPatientSearch.Columns["Address"].Visible = false;
            dgvPatientSearch.Columns["HomePhoneNo"].Visible = false;
            dgvPatientSearch.Columns["MaritalStatus"].Visible = false;
            dgvPatientSearch.Columns["Sex"].Visible = false;
            dgvPatientSearch.Columns["EntryDate"].Visible = false;
            dgvPatientSearch.Columns["HCN"].Visible = false;
            dgvPatientSearch.Columns["DateofBirth"].Visible = false;
            dgvPatientSearch.Columns["PatientName"].Visible = true;
            dgvPatientSearch.Columns["FatherName"].Visible = true;
            dgvPatientSearch.Columns["MotherName"].Visible = true;
            dgvPatientSearch.Columns["SpouseName"].Visible = true;
            dgvPatientSearch.Columns["DateofBirth"].Visible = true;
            dgvPatientSearch.Columns["MobileNo"].Visible = true;
            dgvPatientSearch.Columns["Address"].Visible = true;
            dgvPatientSearch.Columns["HCN"].Visible = true;
            #endregion
            #region DisplayIndex
            dgvPatientSearch.Columns["HCN"].DisplayIndex = 0;
            dgvPatientSearch.Columns["PatientName"].DisplayIndex = 1;
            dgvPatientSearch.Columns["FatherName"].DisplayIndex = 2;
            dgvPatientSearch.Columns["MotherName"].DisplayIndex = 3;
            dgvPatientSearch.Columns["SpouseName"].DisplayIndex = 4;
            dgvPatientSearch.Columns["DateofBirth"].DisplayIndex = 5;
            dgvPatientSearch.Columns["MobileNo"].DisplayIndex = 6;
            dgvPatientSearch.Columns["Address"].DisplayIndex = 7;
            dgvPatientSearch.Columns["SpouseName"].DisplayIndex = 8;
            dgvPatientSearch.Columns["HCN"].DisplayIndex = 9;
            #endregion
            #region Readonly
            dgvPatientSearch.Columns["HCN"].ReadOnly = true;
            dgvPatientSearch.Columns["PatientName"].ReadOnly = true;
            dgvPatientSearch.Columns["DateofBirth"].ReadOnly = true;
            dgvPatientSearch.Columns["Sex"].ReadOnly = true;
            dgvPatientSearch.Columns["FatherName"].ReadOnly = true;
            dgvPatientSearch.Columns["MotherName"].ReadOnly = true;
            dgvPatientSearch.Columns["SpouseName"].ReadOnly = true;
            dgvPatientSearch.Columns["GuardianName"].ReadOnly = true;
            dgvPatientSearch.Columns["RelationshipGuardian"].ReadOnly = true;
            dgvPatientSearch.Columns["Religion"].ReadOnly = true;
            dgvPatientSearch.Columns["BloodGroup"].ReadOnly = true;
            dgvPatientSearch.Columns["EducationLevel"].ReadOnly = true;
            dgvPatientSearch.Columns["Occupation"].ReadOnly = true;
            dgvPatientSearch.Columns["IncomeGroup"].ReadOnly = true;
            dgvPatientSearch.Columns["YearlyIncome"].ReadOnly = true;
            dgvPatientSearch.Columns["NID"].ReadOnly = true;
            dgvPatientSearch.Columns["Email"].ReadOnly = true;
            dgvPatientSearch.Columns["MobileNo"].ReadOnly = true;
            dgvPatientSearch.Columns["Address"].ReadOnly = true;
            dgvPatientSearch.Columns["EntryDate"].ReadOnly = true;
            dgvPatientSearch.Columns["MobileNo"].ReadOnly = true;
            #endregion
        }
        private bool Textboxcheckempty()
        {
            if (PatName == "" && PatFather == "" && PatMother == "" && PatDOB == "" && PatMobile == "" && PatSpouse == "" && PatAdress == "")
            {
                return false;
            }
            return true;
        }

        private void Makewherestring()
        {
            PatName = "";
            PatMobile = "";
            PatDOB = "";
            wherecondition = "";
            PatName = txtPatientName.Text;
            PatMobile = txtMobile.Text;
            PatDOB = dtoDOB.Text;
            PatFather = txtPatFather.Text;
            PatMother = txtPatMother.Text;
            PatSpouse = txtSpouseName.Text;
            PatAdress = txtAddress.Text;
            if (PatDOB == "  /  /")
            {
                PatDOB = "";
            }
            if (!Textboxcheckempty())
            {
                lblError.Text = "Provide at least one field to Search";
                return;
            }
            if (Textboxcheckempty())
            {
                if (txtPatientName.Text != "")
                {
                    PatName = "  WHERE UPPER(PatientName) LIKE " + "'%" + txtPatientName.Text.ToUpper().ToString() + "%'";
                }
                if (PatMobile != "" && PatName == "")
                {
                    PatMobile = "  WHERE UPPER(MOBILENO) LIKE " + "'%" + txtMobile.Text.ToUpper().ToString() + "%'";
                }
                if (PatName != "" && PatMobile != "")
                {
                    PatMobile = "  and UPPER(MOBILENO) LIKE " + "'%" + txtMobile.Text.ToUpper().ToString() + "%'";
                }
                if (PatName == "" && PatMobile == "" && PatDOB != "")
                {
                    PatDOB = "  WHERE DateofBirth IN to_date('" + dtoDOB.Text + "','dd/MM/yyyy'" + ") ";
                }
                if (PatName != "" && PatDOB != "")
                {
                    PatDOB = "  and DateofBirth IN to_date('" + dtoDOB.Text + "','dd/MM/yyyy'" + ") ";
                }
                if (PatMobile != "" && PatDOB != "")
                {
                    PatDOB = "  and DateofBirth IN to_date('" + dtoDOB.Text + "','dd/MM/yyyy'" + ") ";
                }
                #region PatientFather
                if (PatName == "" && PatDOB == "" && PatMother == "" && PatSpouse == "" && PatAdress == "" && PatFather != "")
                {
                    PatFather = "  WHERE UPPER(FATHERNAME) LIKE " + "'%" + txtPatFather.Text.ToUpper().ToString() + "%'";
                }

                if (PatName != "" && PatFather != "")
                {
                    PatFather = "  and UPPER(FATHERNAME) LIKE " + "'%" + txtPatFather.Text.ToUpper().ToString() + "%'";
                }
                if (PatDOB != "" && PatFather != "")
                {
                    PatFather = "  and UPPER(FATHERNAME) LIKE " + "'%" + txtPatFather.Text.ToUpper().ToString() + "%'";
                }
                if (PatMother != "" && PatFather != "")
                {
                    PatFather = "  and UPPER(FATHERNAME) LIKE " + "'%" + txtPatFather.Text.ToUpper().ToString() + "%'";
                }
                if (PatSpouse != "" && PatFather != "")
                {
                    PatFather = "  and UPPER(FATHERNAME) LIKE " + "'%" + txtPatFather.Text.ToUpper().ToString() + "%'";
                }
                if (PatAdress != "" && PatFather != "")
                {
                    PatFather = "  and UPPER(FATHERNAME) LIKE " + "'%" + txtPatFather.Text.ToUpper().ToString() + "%'";
                }
                #endregion
                #region PatientMother

                if (PatName == "" && txtPatMother.Text != "")
                {
                    PatMother = "  WHERE UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";
                }
                if (PatDOB == "" && txtPatMother.Text != "")
                {
                    PatMother = "  WHERE UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";
                }
                if (PatSpouse == "" && txtPatMother.Text != "")
                {
                    PatMother = "  WHERE UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";
                }
                if (PatAdress == "" && txtPatMother.Text != "")
                {
                    PatMother = "  WHERE UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";
                }
                if (PatFather == "" && txtPatMother.Text != "")
                {
                    PatMother = "  WHERE UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";
                }

                if (PatName != "" && txtPatMother.Text != "")
                {
                    PatMother = "  and UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";

                }
                if (PatDOB != "" && txtPatMother.Text != "")
                {
                    PatMother = "  and UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";

                }

                if (PatSpouse != "" && txtPatMother.Text != "")
                {
                    PatMother = "  and UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";

                }
                if (PatAdress != "" && txtPatMother.Text != "")
                {
                    PatMother = "  and UPPER(MotherName) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";

                }
                #endregion
                #region PatientSpouse

                if (PatName == "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  WHERE UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";
                }
                if (PatDOB == "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  WHERE UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";
                }
                if (PatSpouse == "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  WHERE UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";
                }
                if (PatAdress == "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  WHERE UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";
                }
                if (PatFather == "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  WHERE UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";
                }

                if (PatName != "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  and UPPER(SPOUSENAME) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";

                }
                if (PatDOB != "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  and UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";

                }

                if (PatMother != "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  and UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";

                }
                if (PatAdress != "" && txtSpouseName.Text != "")
                {
                    PatSpouse = "  and UPPER(SPOUSENAME) LIKE " + "'%" + txtSpouseName.Text.ToUpper().ToString() + "%'";

                }
                #endregion
                #region PatientAddress

                if (PatName == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }
                if (PatDOB == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }
                if (PatSpouse == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }
                if (PatAdress == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }
                if (PatFather == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }
                if (PatMobile == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }
                if (PatMother == "" && txtAddress.Text != "")
                {
                    PatAdress = "  WHERE UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";
                }

                if (PatName != "" && txtAddress.Text != "")
                {
                    PatAdress = "  and UPPER(ADDRESS) LIKE " + "'%" + txtPatMother.Text.ToUpper().ToString() + "%'";

                }
                if (PatDOB != "" && txtAddress.Text != "")
                {
                    PatAdress = "  and UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";

                }

                if (PatMother != "" && txtAddress.Text != "")
                {
                    PatAdress = "  and UPPER(ADDRESS) LIKE " + "'%" + txtAddress.Text.ToUpper().ToString() + "%'";

                }

                #endregion
                wherecondition = PatName + PatMobile + PatDOB + PatFather + PatMother + PatSpouse + PatAdress;
            }
        }

        private void MakeSearch()
        {
            if (!Textboxcheckempty())
            {
                lblError.Text = "Provide at least one field to Search";
                return;
            }
            List<PatRegRO> oPatRegROs = new List<PatRegRO>();
            oPatRegROs = clnt.PatientAdvanceSearch(wherecondition).ToList<PatRegRO>();
            if (oPatRegROs.Count > 0)
            {
                dgvPatientSearch.DataSource = null;

                dgvPatientSearch.DataSource = oPatRegROs;
                StyleDataGrid();
                dgvPatientSearch.ClearSelection();
            }
            if (oPatRegROs.Count <= 0)
            {
                dgvPatientSearch.DataSource = null;
                lblError.Text = "No Data Found";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            Makewherestring();
            MakeSearch();
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        private void dgvPatientSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int position = dgvPatientSearch.CurrentRow.Index;
            string hcn = dgvPatientSearch.Rows[position].Cells["HCN"].Value.ToString();

            if (onPrintButtonClicked != null)
                onPrintButtonClicked(hcn, sender, e);
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            Makewherestring();
            MakeSearch();
        }

        private void txtPatientName_TextChanged_1(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        private void txtPatFather_TextChanged(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        private void txtPatMother_TextChanged(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        private void txtSpouseName_TextChanged(object sender, EventArgs e)
        {
            //lblError.Text = "";
            //Makewherestring();
            //MakeSearch();
        }

        
        
    }
}
