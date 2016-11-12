using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.HRSR;
using AH.DUtility;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmPayrollBaseSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public List<IncomeTax> oIncomeTaxs;
        public List<EmployeeMaster> oEmpMas;
        int flag = 0;
        double Basic = 0;
        double HouseRent = 0;
        double MedicalAllowance = 0;
        double Transport = 0;
        double IncomeTax = 0;
        double Amount = 0;
        double Cash;
        double Age = 0;
        public frmPayrollBaseSetup()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> GetFiscalYear()
        {
            Dictionary<string, string> locFiscalYear = new Dictionary<string, string>();
            locFiscalYear.Add("2013-2014", "2013-2014");
            locFiscalYear.Add("2014-2015", "2014-2015");
            locFiscalYear.Add("2015-2016", "2015-2016");
            locFiscalYear.Add("2016-2017", "2016-2017");
            locFiscalYear.Add("2017-2018", "2017-2018");
            locFiscalYear.Add("2018-2019", "2018-2019");
            locFiscalYear.Add("2019-2020", "2019-2020");
            return locFiscalYear;
        }     
        public void GetCurrentFinancialYear()
        {
            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();
            string FinYear = null;

            if (DateTime.Today.Month > 6)

                FinYear = CurYear + "-" + NexYear;

            else

                FinYear = PreYear + "-" + CurYear;

            cboFiscalYear.Text = FinYear.Trim();
        }
        private void FormatGrid()
        {
            dgvSalaryHead.ColumnCount = 3;
            this.dgvSalaryHead.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvSalaryHead.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvSalaryHead.Columns[0].Name = "Head ID";
            dgvSalaryHead.Columns[0].Width = 0;
            dgvSalaryHead.Columns[0].Visible = false;
            dgvSalaryHead.Columns[1].Name = "Salary Head";
            dgvSalaryHead.Columns[1].Width = 300;
            dgvSalaryHead.Columns[1].ReadOnly = true;
            dgvSalaryHead.Columns[2].Name = "Amount";
            dgvSalaryHead.Columns[2].Width = 302;
            dgvSalaryHead.Columns[2].ReadOnly = false ;           
            dgvSalaryHead.Font = new Font("Tahoma", 10);
        }
        private void frmPayrollBaseSetup_Load(object sender, EventArgs e)
        {
            cboFiscalYear.DisplayMember = "Value";
            cboFiscalYear.ValueMember = "Key";
            cboFiscalYear.DataSource = new BindingSource(GetFiscalYear(), null);
            GetCurrentFinancialYear();
           
            FormatGrid(); 
            txtEmpID.Focus();            
        }
      
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dgvSalaryHead.Rows.Clear();
            txtNetBank.Text = "";
            txtNewCash.Text = "";
            txtGross.Text = "";
            txtTotalSal.Text = "";
            txtFinalGross.Text = "";
            int count;
            int i = 0;
            if(txtEmpID.Text =="")
            {
                MessageBox.Show("Please Provide a Valid Employee ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpID.Focus();
                return;
            }
            if(txtConsolidateFlag.Text!="0")
            {
                MessageBox.Show("Can't Generate Base,Because This Employee Salary is Consolidate", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpID.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Provide a Amount to Generate Base", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }
            Amount = Convert.ToDouble(txtAmount.Text);
            oEmpMas = hmsSC.GetEmpGender(txtEmpID.Text.ToString()).ToList();
            foreach (EmployeeMaster oEmp in oEmpMas)
            {
                txtGender.Text = oEmp.Sex.ToString();
                Age = Convert.ToDouble(oEmp.Age);
                txtJobType.Text = oEmp.JobType.ToString();
            }
            List<SalaryHead> oSalHeads = hmsSC.GetSalaryHead().ToList();
            count = oSalHeads.Count;
            if (count > 0)
            {
                dgvSalaryHead.Rows.Add(count);
                foreach (SalaryHead oSalHead in oSalHeads)
                {
                    dgvSalaryHead.Rows[i].Cells[0].Value = oSalHead.HeadID;
                    dgvSalaryHead.Rows[i].Cells[1].Value = oSalHead.HeadTitle;
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "001")
                    {
                        Basic = Amount * 0.60;
                        dgvSalaryHead.Rows[i].Cells[2].Value = Convert.ToDouble(Basic);
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "002")
                    {
                        HouseRent = Basic * 0.50;
                        dgvSalaryHead.Rows[i].Cells[2].Value = Convert.ToDouble(HouseRent);
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "003")
                    {
                        Transport = Amount * 0.04;
                        dgvSalaryHead.Rows[i].Cells[2].Value = Convert.ToDouble(Transport);
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "004")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "005")
                    {
                        MedicalAllowance = Basic * 0.10;
                        dgvSalaryHead.Rows[i].Cells[2].Value = Convert.ToDouble(MedicalAllowance);
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "006")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "007")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "008")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "009")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                   
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "010")
                    {
                        IncomeTaxFormula(Basic, HouseRent, MedicalAllowance, Transport);
                        dgvSalaryHead.Rows[i].Cells[2].Value = IncomeTax;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "011")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "012")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "013")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "014")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "015")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "016")
                    {
                        if (txtCash.Text.ToString() == "")
                        {
                            dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        }
                        if (txtCash.Text.ToString() != "")
                        {
                            dgvSalaryHead.Rows[i].Cells[2].Value = txtCash.Text.ToString();
                            txtNewCash.Text = txtCash.Text.ToString();
                        }
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.Honeydew;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.Honeydew;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "017")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "018")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "019")
                    {
                        dgvSalaryHead.Rows[i].Cells[2].Value = 0;
                        dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                        dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                    }
                    i = i + 1;                    
                }
                flag = 1;
            }
        }
        private void IncomeTaxFormula(double Basic, double HRA, double MA, double Conveyance)
        {
            double Slot1 = 0;
            double Slot1Payable = 0;           
            double Slot1Rest=0;
            double Slot2 = 0;
            double Slot2Payable = 0;
            double Slot2Rest = 0;
            double Slot3 = 0;
            double Slot3Payable = 0;
            double Slot3Rest = 0;
            double Slot4 = 0;
            double Slot4Payable = 0;
            double Slot4Rest = 0;
            double Slot5 =0;
            double Slot5Payable = 0;
            double PayableTax = 0;
            double FinalTaxableAmt = 0;
            double NoIncomeTax = 0;
            double HRARest = 0;
            double MARest = 0;
            double CARest = 0;
            double NetTaxPayablePerMonth = 0;
            double ITBasic = 0;
            oIncomeTaxs = hmsSC.GetIncomeTaxInfo(cboFiscalYear.SelectedValue.ToString(), txtGender.Text.ToString()).ToList();
            foreach (IncomeTax oIncome in oIncomeTaxs)
            {
                txtHraExm.Text = oIncome.HraExm;
                txtMAExm.Text = oIncome.MaExm;
                txtConveyance.Text = oIncome.ConExm;
                txtTaxFreeLimit.Text = oIncome.TaxFreeLimit;
                txtInvstTaxRebate.Text = oIncome.InvstTaxRebat;
                txtInvstLimit.Text = oIncome.InvstLimit;
                txtSlot1.Text = oIncome.Slot1;
                txtSlot2.Text = oIncome.Slot2;
                txtSlot3.Text = oIncome.Slot3;
                txtSlot4.Text = oIncome.Slot4;
                txtSlot5.Text = oIncome.Slot5;
                txtMinTaxAmt.Text = oIncome.MinTaxAmt;
                txtSlot1Limit.Text = oIncome.Slot1Limit;
                txtSlot2Limit.Text = oIncome.Slot2Limit;
                txtSlot3Limit.Text = oIncome.Slot3Limit;
                txtSlot4Limit.Text = oIncome.Slot4Limit;
                txtSlot5Limit.Text = oIncome.Slot5Limit;

                double Gross = Convert.ToDouble(txtAmount.Text.ToString());
                if (txtJobType.Text == "C")
                {
                    ITBasic = Basic * 12;
                }
                else
                {
                    ITBasic = Basic * 14;
                }
                double ITHRA = (HouseRent * 12) - Convert.ToDouble(txtHraExm.Text);
                if(ITHRA<0)
                {
                    HRARest = 0;
                }
                else
                {
                    HRARest = ITHRA;
                }
                double ITMA = (MedicalAllowance * 12) - Convert.ToDouble(txtMAExm.Text);
                if(ITMA<0)
                {
                    MARest = 0;
                }
                else
                {
                    MARest = ITMA;
                }
                double ITConveyance = (Transport * 12) - Convert.ToDouble(txtConveyance.Text);
                if(ITConveyance<0)
                {
                    CARest = 0;
                }
                else
                {
                    CARest = ITConveyance;
                }
                double TaxableIncome = ITBasic + HRARest + MARest + CARest;
                double TotalTaxFreePayable = TaxableIncome - Convert.ToDouble(txtTaxFreeLimit.Text);

                //Investment & Tax Rebate Part//
                double InvstLimit = TaxableIncome * (Convert.ToDouble(txtInvstLimit.Text) / 100);               
                double TaxRebate = InvstLimit * (Convert.ToDouble(txtInvstTaxRebate.Text) / 100);
                //*****************************//
              
                if (TotalTaxFreePayable <0)
                {
                    NoIncomeTax = 1;                   
                }
                //Slot 1 Calculation//
                if (TotalTaxFreePayable >0 && TotalTaxFreePayable < Convert.ToDouble(txtSlot1Limit.Text))
                {
                    Slot1 = Math.Round(TotalTaxFreePayable * (Convert.ToDouble(txtSlot1.Text) / 100), 0);
                    if (Slot1 < Convert.ToDouble(txtMinTaxAmt.Text))
                    {
                        Slot1Payable = Convert.ToDouble(txtMinTaxAmt.Text);
                    }
                    if (Slot1 > Convert.ToDouble(txtMinTaxAmt.Text))
                    {
                        Slot1Payable = Convert.ToDouble(Slot1);
                    }
                }
                if (TotalTaxFreePayable > Convert.ToDouble(txtSlot1Limit.Text))
                {
                    Slot1 = Math.Round(Convert.ToDouble(txtSlot1Limit.Text) * (Convert.ToDouble(txtSlot1.Text) / 100), 0);
                    Slot1Payable = Convert.ToDouble(Slot1);
                    Slot1Rest = Math.Round(TotalTaxFreePayable - Convert.ToDouble(txtSlot1Limit.Text), 0);
                }
                //******************//

                //Slot 2 Calculation//
                if (Slot1Rest < Convert.ToDouble(txtSlot2Limit.Text))
                {
                    Slot2 = Math.Round(Slot1Rest * (Convert.ToDouble(txtSlot2.Text) / 100), 0);
                    Slot2Payable=Convert.ToDouble(Slot2);
                    PayableTax = Slot1Payable + Slot2Payable;
                }
                if (Slot1Rest > Convert.ToDouble(txtSlot2Limit.Text))
                {
                    Slot2 = Math.Round(Convert.ToDouble(txtSlot2Limit.Text) * (Convert.ToDouble(txtSlot2.Text) / 100), 0);
                    Slot2Payable = Convert.ToDouble(Slot2);
                    Slot2Rest = Math.Round(Slot1Rest - Convert.ToDouble(txtSlot2Limit.Text), 0);
                }
                //******************//

                //Slot 3 Calculation//
                if (Slot2Rest < Convert.ToDouble(txtSlot3Limit.Text))
                {
                    Slot3 = Math.Round(Slot2Rest * (Convert.ToDouble(txtSlot3.Text) / 100), 0);
                    Slot3Payable = Convert.ToDouble(Slot3);
                    PayableTax = Slot1Payable + Slot2Payable + Slot3Payable;
                }
                if (Slot2Rest > Convert.ToDouble(txtSlot3Limit.Text))
                {
                    Slot3 = Math.Round(Convert.ToDouble(txtSlot3Limit.Text) * (Convert.ToDouble(txtSlot3.Text) / 100), 0);
                    Slot3Payable = Convert.ToDouble(Slot3);
                    Slot3Rest = Math.Round(Slot2Rest - Convert.ToDouble(txtSlot3Limit.Text), 0);
                }
                //******************//

                //Slot 4 Calculation//
                if (Slot3Rest < Convert.ToDouble(txtSlot4Limit.Text))
                {
                    Slot4 = Math.Round(Slot3Rest * (Convert.ToDouble(txtSlot4.Text) / 100), 0);
                    Slot4Payable = Convert.ToDouble(Slot4);
                    PayableTax = Slot1Payable + Slot2Payable + Slot3Payable + Slot4Payable;
                }
                if (Slot3Rest > Convert.ToDouble(txtSlot4Limit.Text))
                {
                    Slot4 = Math.Round(Convert.ToDouble(txtSlot4Limit.Text) * (Convert.ToDouble(txtSlot4.Text) / 100), 0);
                    Slot4Payable = Convert.ToDouble(Slot4);
                    Slot4Rest = Math.Round(Slot3Rest - Convert.ToDouble(txtSlot4Limit.Text), 0);                  
                }
                //******************//

                //Slot 5 Calculation//
                if (Slot4Rest < Convert.ToDouble(txtSlot5Limit.Text))
                {
                    Slot5 = Math.Round(Slot4Rest * (Convert.ToDouble(txtSlot5.Text) / 100), 0);
                    Slot5Payable = Convert.ToDouble(Slot5);
                    PayableTax = Slot1Payable + Slot2Payable + Slot3Payable + Slot4Payable + Slot5Payable;
                }
                FinalTaxableAmt = PayableTax - TaxRebate;
                if (NoIncomeTax == 1)
                {
                    IncomeTax = 0;
                }
                if ((NoIncomeTax==0) && FinalTaxableAmt <= Convert.ToDouble(txtMinTaxAmt.Text))
                {
                    NetTaxPayablePerMonth = Math.Round(Convert.ToDouble(txtMinTaxAmt.Text)/ 12, 0); 
                    IncomeTax = NetTaxPayablePerMonth;
                }
                if (FinalTaxableAmt > Convert.ToDouble(txtMinTaxAmt.Text))
                {
                    NetTaxPayablePerMonth = Math.Round(FinalTaxableAmt / 12, 0);
                    IncomeTax = NetTaxPayablePerMonth;
                }
            }
        }      
        private void txtEmpID_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);
            if (txtEmpID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpID.Text != "")
            {
                if (txtEmpID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                    txtConsolidateFlag.Text = oEmpMas.ConsolidateScaleFlag.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                    dgvSalaryHead.Rows.Clear();                   
                }
            }
        }
        private PayrollBase PopulatePayrollBase()
        {
            int j;
            string string1 = "";
            PayrollBase oPayrollBase = new PayrollBase();

            EmployeeMaster oEmpMaster = new EmployeeMaster();
            oEmpMaster.EmpId = txtEmpID.Text.ToString();
            oPayrollBase.EmployeeMaster = oEmpMaster;
         
            for (j = 0; j < dgvSalaryHead.Rows.Count; j++)
            {
                string1 += dgvSalaryHead.Rows[j].Cells[0].Value.ToString() + ":" +
                           dgvSalaryHead.Rows[j].Cells[2].Value.ToString() + ":" + ";";
            }
            oPayrollBase.SalaryHeadString = string1;            

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPayrollBase.EntryParameter = ep;
            return oPayrollBase;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtAmount"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(dgvSalaryHead.Rows.Count==0)
            {
                MessageBox.Show("Please Generate Salary Base..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (flag == 1)
                {
                    PayrollBase oPayrollBase = this.PopulatePayrollBase();
                    short i = hmsSC.SavePayrollBase(oPayrollBase);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnShow_Click(sender, e);
                        flag = 0;
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
        private void LoadListView(string EmpID)
        {
              dgvSalaryHead.Rows.Clear();
              txtAmount.Text = "";
              txtCash.Text = "";
              txtNewCash.Text = "";
              txtGross.Text = "";
              txtNetBank.Text = "";
              txtFinalGross.Text = "";
              txtTotalSal.Text = "";
              Cash = 0;
               int i = 0;
               List<PayrollBase> oPayrollBases = hmsSC.GetPayrollBase(txtEmpID.Text.ToString()).ToList();
               if (oPayrollBases.Count > 0)
                {
                    foreach (PayrollBase oPayBase in oPayrollBases)
                    {
                        dgvSalaryHead.Rows.Add(1);
                        dgvSalaryHead.Rows[i].Cells[0].Value = oPayBase.SalaryHead.HeadID;
                        dgvSalaryHead.Rows[i].Cells[1].Value = oPayBase.SalaryHead.HeadTitle;
                        dgvSalaryHead.Rows[i].Cells[2].Value = oPayBase.amount;
                        if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "001" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "002" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "003" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "004" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "005" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "006" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "007" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "008" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "009")
                        {
                            dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightGoldenrodYellow;
                            dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightGoldenrodYellow;
                        }
                        if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "010" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "011" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "012" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "013" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "014" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "015" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "017" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "018" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "019")
                        {
                            dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.LightSkyBlue;
                            dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.LightSkyBlue;
                        }
                        if(dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "016")
                        {
                            Cash =Convert.ToDouble(dgvSalaryHead.Rows[i].Cells[2].Value);
                            dgvSalaryHead.Rows[i].Cells[1].Style.BackColor = Color.Honeydew;
                            dgvSalaryHead.Rows[i].Cells[2].Style.BackColor = Color.Honeydew;
                        }
                        i = i + 1;
                    }                  
              }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListView(txtEmpID.Text.ToString());
            txtAmount.Text = "";
            txtCash.Text = "";
            txtNewCash.Text = Cash.ToString();
            if (txtGross.Text != "")
            {
                if (txtNewCash.Text != "")
                {
                    double bank = Convert.ToDouble(txtGross.Text.ToString());
                    double Netbank = Convert.ToDouble(txtNetBank.Text.ToString());
                    double cash = Convert.ToDouble(txtNewCash.Text.ToString());
                    double finalgross = bank + cash;
                    double finalNet = Netbank + cash;
                    txtFinalGross.Text = finalgross.ToString();
                    txtTotalSal.Text = finalNet.ToString();
                }
            }           
            flag = 0;
        }
        private void dgvSalaryHead_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Addition = 0;
                int Deduction = 0;
                int Gross = 0;
                int TotSal = 0;
                int TotCas = 0;

                for (int i = 0; i < dgvSalaryHead.Rows.Count - 1; i++)
                {
                    if (dgvSalaryHead.Rows[i].Cells[2].Value != null)
                    {
                        txtGross.Visible = true;
                        lblNewGross.Visible = true;
                        if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "001" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "002" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "003" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "004" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "005" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "006" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "007" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "008" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "009" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "016")
                        {
                            Addition += Convert.ToInt32(dgvSalaryHead.Rows[i].Cells["Amount"].Value);
                        }
                        if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "010" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "011" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "012" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "013" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "014" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "015" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "017" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "018" || dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "019")
                        {
                            Deduction += Convert.ToInt32(dgvSalaryHead.Rows[i].Cells["Amount"].Value);
                        }
                        if (dgvSalaryHead.Rows[i].Cells[0].Value.ToString() == "016")
                        {
                            TotCas = Convert.ToInt32(dgvSalaryHead.Rows[i].Cells["Amount"].Value);
                        }
                        Gross = Addition - Deduction - TotCas;
                        TotSal = Addition - TotCas;
                    }
                    txtNetBank.Text = Convert.ToString(TotSal);
                    txtGross.Text = Convert.ToString(Gross);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNewClose_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DialogResult msg = MessageBox.Show("Payroll Base is not Saved,Do You want to Save?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                    this.Dispose();
                }
                if (msg == DialogResult.No)
                {
                    this.Dispose();
                }
            }
            if (flag == 0)
            {
                this.Dispose();
            }

        }
        private void dgvSalaryHead_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (e.ColumnIndex == 2)
            {
                double i;
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {                              
                    e.Cancel = true;
                    MessageBox.Show("Please Enter Numeric Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvSalaryHead.Rows.Clear();
            lblInfo.Text = "";
            txtConsolidateFlag.Text = "";
        }      
    }
}
