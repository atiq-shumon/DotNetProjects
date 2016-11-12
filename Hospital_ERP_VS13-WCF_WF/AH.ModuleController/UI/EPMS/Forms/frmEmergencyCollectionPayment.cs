using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;
using AH.Shared.UI;
using AH.ModuleController.UI.DMS.Reports.Viewer;
using System.Threading.Tasks;
using AH.ModuleController.UI.DMS.Forms;

namespace AH.ModuleController.UI.EPMS.Forms
{
    public partial class frmEmergencyCollectionPayment : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSR = new DMSSR.DMSWSClient();
        public frmEmergencyCollectionPayment()
        {
            InitializeComponent();
        }

        private void frmEmergencyCollectionPayment_Load(object sender, EventArgs e)
        {
            FormatGrid();

            cboTicketType.DisplayMember = "Value";
            cboTicketType.ValueMember = "Key";
            cboTicketType.DataSource = new BindingSource(Utility.GetPrescriptionTypes(), null);

            cboTicketType.SelectedValue = "E";
            cboTicketType.Enabled = false;

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboDepartmentType.Text = "Medical";
            cboDepartmentType.Enabled = false;
            cboDepartmentGroup.Text = "Clinical";
            cboDepartmentGroup.Enabled = false;
            cboDepartment.Text = "Emergency";
            cboDepartment.Enabled = false;
            cboUnit.Text = "--";
            cboUnit.Enabled = false;
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(dmsSR.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(dmsSR.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(dmsSR.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }
        private void FormatGrid()
        {
            dgvAssignedCollectionHead.ColumnCount = 5;
            this.dgvAssignedCollectionHead.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvAssignedCollectionHead.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);           
            dgvAssignedCollectionHead.Columns[0].Name = "ID";
            dgvAssignedCollectionHead.Columns[0].Width = 100;
            dgvAssignedCollectionHead.Columns[0].ReadOnly = true;
            this.dgvAssignedCollectionHead.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F, FontStyle.Regular);
            dgvAssignedCollectionHead.Columns[1].Name = "Name";
            dgvAssignedCollectionHead.Columns[1].Width = 600;
            dgvAssignedCollectionHead.Columns[1].ReadOnly = true;
            this.dgvAssignedCollectionHead.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F, FontStyle.Regular);
            dgvAssignedCollectionHead.Columns[2].Name = "Fee";
            dgvAssignedCollectionHead.Columns[2].Width = 120;
            dgvAssignedCollectionHead.Columns[2].ReadOnly = true;
            this.dgvAssignedCollectionHead.Columns[2].DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F, FontStyle.Regular);
            dgvAssignedCollectionHead.Columns[3].Name = "Qty";
            dgvAssignedCollectionHead.Columns[3].Width = 80;
            dgvAssignedCollectionHead.Columns[3].ReadOnly = true;
            dgvAssignedCollectionHead.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvAssignedCollectionHead.Columns[3].DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F, FontStyle.Regular);
            dgvAssignedCollectionHead.Columns[4].Name = "Total";
            dgvAssignedCollectionHead.Columns[4].Width = 170;
            dgvAssignedCollectionHead.Columns[4].ReadOnly = true;
            this.dgvAssignedCollectionHead.Columns[4].DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F, FontStyle.Regular);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Patient pat;
            pat = dmsSR.GetPatient(txtHCNNo.Text, "E");
            LoadPatient(pat);

            LoadAssignedEmergencyCollection();          
        }
        private void LoadPatient(Patient pat)
        {
            txtPatientName.Text = pat.Name;
            DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;
            txtMobileNo.Text = pat.CellPhone;
            txtHCNNo.Text = pat.HCN;
            txtTicketNo.Text = "";
            txtPresentAddress.Text = pat.Present_H_R_B + Utility.CrLf + Utility.CrLf + pat.PresentThana + ", " + pat.PresentDistrict;
        }
        private void LoadAssignedEmergencyCollection()
        {
            try
            {
                dgvAssignedCollectionHead.DataSource = null;
                dgvAssignedCollectionHead.Rows.Clear();
                List<EmergencyCollectionMR> oEmrs = dmsSR.GetEmerMRNo(txtHCNNo.Text.ToString()).ToList();
                foreach (EmergencyCollectionMR oEmr in oEmrs)
                {
                    txtTicketNo.Text = oEmr.EmergencyMR;                    
                }
                int i = 0;
                List<EmergencyCollectionMR> rshd = dmsSR.GetEmerBillForPayment(txtHCNNo.Text.ToString()).ToList();
                if (rshd.Count > 0)
                {

                    foreach (EmergencyCollectionMR rsh in rshd)
                    {
                        dgvAssignedCollectionHead.Rows.Add(1);
                        dgvAssignedCollectionHead.Rows[i].Cells[0].Value = rsh.EmrCollHead.HeadID;
                        dgvAssignedCollectionHead.Rows[i].Cells[1].Value = rsh.EmrCollHead.HeadTitle;
                        dgvAssignedCollectionHead.Rows[i].Cells[2].Value = rsh.EmrCollHead.Fee;
                        dgvAssignedCollectionHead.Rows[i].Cells[3].Value = rsh.EmrCollHead.Qty;
                        if (rsh.EmrCollHead.HeadID == "000049")
                        {
                            dgvAssignedCollectionHead.Rows[i].Cells[4].Value = Convert.ToDouble(rsh.EmrCollHead.Fee);
                        }
                        else
                        {
                            dgvAssignedCollectionHead.Rows[i].Cells[4].Value = Convert.ToDouble(rsh.EmrCollHead.Fee) * Convert.ToDouble(rsh.EmrCollHead.Qty);
                        }
                        i = i + 1;
                    }
                    dgvAssignedCollectionHead.AllowUserToAddRows = false;
                    updateCollectedTestSummary(dgvAssignedCollectionHead);
                }
                else
                {
                    lblTestCount.Text = "";
                    lblTestAmountSummary.Text = "";
                    return;
                }
                dgvAssignedCollectionHead.CurrentCell = null;
                dgvAssignedCollectionHead.ClearSelection();
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

        private void updateCollectedTestSummary(DataGridView dtv)
        {
            lblTestCount.Text = dtv.RowCount.ToString();
            double sum = 0;
            for (int i = 0; i < dtv.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dtv.Rows[i].Cells[4].Value.ToString());
            }
            lblTestAmountSummary.Text = sum.ToString();
        }
        private void txtTicketNo_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtTicketNo.Text.Length == Utility.ScanLength)
            //{
            //    btnSearch_Click(sender, e);
            //}
        }

        private void txtTicketNo_TextChanged(object sender, EventArgs e)
        {
            txtTicketNo.CharacterCasing = CharacterCasing.Upper;
        }
        private void clear()
        {
            txtHCNNo.Text = "";
            txtMobileNo.Text = "";
            txtPatientName.Text = "";
            txtSex.Text = "";
            txtAgeYears.Text = "";
            txtAgeMonths.Text = "";
            txtAgeDays.Text = "";
            txtAgeHours.Text = "";
            txtPresentAddress.Text = "";
            lblTestCount.Text = "0";
            lblTestAmountSummary.Text = "0";
            txtEmergencyMRNo.Text = "";
            txtTicketNo.Text = "";
            dgvAssignedCollectionHead.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtHCNNo", "txtPatientName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSR.VerifyPatientNo(txtHCNNo.Text) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHCNNo.Focus();
                return;
            }
            if (dgvAssignedCollectionHead.Rows.Count == 0)
            {
                MessageBox.Show("No Collection Head is Selected..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string label = "Emergency Money Receipt Issue";
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.DiagnosticColl);
            string patNo = txtHCNNo.Text;
            string patName = txtPatientName.Text;
            string department = cboDepartment.SelectedValue.ToString();
            string departmentUnit = cboUnit.SelectedValue.ToString();
            string reffDepartment = cboDepartment.SelectedValue.ToString();
            string departmentReffUnit = cboUnit.SelectedValue.ToString();
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = lblTestAmountSummary.Text;
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "0";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            if (cboTicketType.SelectedValue.ToString() != "I")
            {
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat.ToString(),
                                                discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit,
                                                departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.ShowDialog();
            }
        }
        private object PaymentObject(AH.Shared.MODEL.OPDPayment payment)
        {
            OPDPayment paymentObject = new OPDPayment();
            paymentObject.Advance = payment.Advance;
            paymentObject.Amount = payment.Amount;
            paymentObject.CompanyID = payment.CompanyID;
            paymentObject.ConsultantFee = payment.ConsultantFee;
            paymentObject.Department = payment.Department;
            paymentObject.DepartmentUnit = payment.DepartmentUnit;
            paymentObject.DeptAmount = payment.DeptAmount;
            paymentObject.Discount = payment.Discount;
            paymentObject.EntryBy = payment.EntryBy;
            paymentObject.EntryDate = payment.EntryDate;
            paymentObject.EntryName = payment.EntryName;
            paymentObject.HCN = payment.HCN;
            paymentObject.LocationID = payment.LocationID;
            paymentObject.MachineID = payment.MachineID;
            paymentObject.NetAmount = payment.NetAmount;
            paymentObject.PaymentDate = payment.PaymentDate;
            paymentObject.PaymentType = payment.PaymentType;
            paymentObject.PreviousDue = payment.PreviousDue;
            paymentObject.PurposeID = payment.PurposeID;
            paymentObject.PurposeTitle = payment.PurposeTitle;
            paymentObject.ReffDept = payment.ReffDept;
            paymentObject.ReffDeptAmount = payment.ReffDeptAmount;
            paymentObject.ReffDeptUnit = payment.ReffDeptUnit;
            paymentObject.RefferedFee = payment.RefferedFee;
            paymentObject.RegistrationNo = payment.RegistrationNo;
            paymentObject.Staff = payment.Staff;
            paymentObject.TransactionNo = payment.TransactionNo;
            paymentObject.VAT = payment.VAT;
            paymentObject.Amount = payment.AmountGiven;
            paymentObject.AmountGiven = payment.AmountGiven;
            paymentObject.PaymentString = payment.PaymentString;

            return paymentObject;
        }
        private EmergencyCollectionMR PopulateEmrCollPayment(OPDPayment payment)
        {
            EmergencyCollectionMR oEmrCollMR = new EmergencyCollectionMR();
            EmrCollHead oCollHd = new EmrCollHead();
           
            TestFee oTestFee = new TestFee();
            oTestFee.DiscountType = "0";
            oTestFee.DiscountReff = "0";
            oTestFee.DiscountAuthority = "0";
            oEmrCollMR.test = oTestFee;
                      
            Ticket tkt = new Ticket();
            tkt.TicketNo = txtTicketNo.Text.ToString();
            tkt.TicketType = "E";
            oEmrCollMR.Ticket = tkt;

            InPatient pat = new InPatient();
            pat.HCN = txtHCNNo.Text;
            AH.ModuleController.DMSSR.Age patientAge = new AH.ModuleController.DMSSR.Age();
            patientAge.Year = int.Parse(txtAgeYears.Text);
            patientAge.Month = int.Parse(txtAgeMonths.Text);
            patientAge.Day = int.Parse(txtAgeDays.Text);
            patientAge.Hour = int.Parse(txtAgeHours.Text);
            pat.AgeBreakDown = patientAge;

            oEmrCollMR.EmrCollHead = oCollHd;
            oEmrCollMR.Patient = pat;

            oEmrCollMR.EmergencyMR = txtEmergencyMRNo.Text.ToString();
            oEmrCollMR.AdmissionID = "0";
            oEmrCollMR.DiagnosticPayment = payment;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmrCollMR.EntryParameter = ep;

            return oEmrCollMR;
        }

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                EmergencyCollectionMR oEmerCollMR = this.PopulateEmrCollPayment((OPDPayment)PaymentObject(payment));
                string i = dmsSR.SaveEmergencyCollectionPayment(oEmerCollMR);
                txtTicketNo.Text = i;
                printMR(txtTicketNo.Text);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtHCNNo.Focus();
            clear();
        }
        private void printMR(string mrNo)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.EmergencyMR;
            vr.MoneyReceiptNo = mrNo;
            vr.ViewReport();
        }

        private void txtHCNNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHCNNo.Text.Length == Utility.ScanLength)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtHCNNo_TextChanged(object sender, EventArgs e)
        {
            txtHCNNo.CharacterCasing = CharacterCasing.Upper;
        }

    }
}
