using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using AH.DUtility;
using AH.Shared.UI;
using AH.ModuleController.PHRMSSR;
using AH.ModuleController.UI.PHRMS.Reports.Viewer;
using System.Globalization;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmDrugIssue : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        private string pharmacyID, salesType;
        GroupBox dummy;
        List<Patient> pats;

        public frmDrugIssue(string pharmacyID,string salesType)
        {
            InitializeComponent();
            this.pharmacyID = pharmacyID;
            this.salesType = salesType;

            dummy = new GroupBox();
            dummy.Visible = false;
            dummy.Enabled = false;
            this.Controls.Add(dummy);
           
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            lvHcnLists.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtTransactionType", "cboCostCategoey", "cboCostCenter" };
            Control control = Utility.ReqFieldValidator(this, vf);


            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(lvDrugIssue.Items.Count == 0)
            {
                MessageBox.Show("Please select Drug");
                return;
            }
            if(this.salesType == "I")
            {
                if (string.IsNullOrEmpty(txtReceivedBy.Text))
                {
                    MessageBox.Show("Please Fill ReceiveBy");
                    txtReceivedBy.Select();
                    return;
                }

            }

            //if (labelTotalMedicine.Text == "0")
            //{
            //    MessageBox.Show("Total Medicine cannot be zero");
            //    return;
            //}
            foreach (ListViewItem lvw in lvDrugIssue.Items)
            {
                if (Utility.ParseFloat(lvw.SubItems[10].Text).ToString() == "0")
                {
                    MessageBox.Show("Quantity can not be zero");
                    return;
                }
                if (Utility.ParseFloat(lvw.SubItems[14].Text).ToString() == "0")
                {
                    MessageBox.Show("Total Stock is zero");
                    return;
                }
                if (this.salesType == "O" || this.salesType == "X")
                {
                    if (phrSr.VarifyExpireDate("0007", lvw.SubItems[0].Text) == 0)
                    {
                        MessageBox.Show("The red mark Medicine is expired");
                        return;
                    }
                }
                if (this.salesType == "I")
                {
                    if (phrSr.VarifyExpireDate("0061", lvw.SubItems[0].Text) == 0)
                    {
                        MessageBox.Show("The red mark Medicine is expired");
                        return;
                    }
                }

            }    

            string label = "Payment for Drug Purchase";
            string patNo = txtHCN.Text;
            string patName = lblPatientName.Text;
            string department = txtDepartmentID.Text;
            string departmentUnit = txtDepartmentUnitID.Text;
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 300;
            decimal reffDepartmentAmount = 0;
            string amount = lblGrandTotal.Text;
            string advance = "0";
            string vat = Utility.Vat.ToString();
            string discount = "0";
            string discountBy = "0";
            string paymentType = "0";
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.OPDPharmacyCollection);
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            //string RoomNo = txtRoom.Text;
            //string AppID = txtAppointment.Text;
            if (this.salesType == "I")
            {
                try
                {

                    OPDPayment paymentObject = new OPDPayment();
                    paymentObject.Advance =0;
                    paymentObject.Amount = 0;
                    paymentObject.CompanyID = "0";
                    paymentObject.ConsultantFee = 0;
                    paymentObject.Department = "0";
                    paymentObject.DepartmentUnit = "0";
                    paymentObject.DeptAmount = 0;
                    paymentObject.Discount = 0;
                    paymentObject.EntryBy = Utility.UserId;
                    paymentObject.EntryDate = DateTime.Now;
                    paymentObject.EntryName = "Atiq";
                    paymentObject.HCN = "0124";
                    paymentObject.LocationID = "01";
                    paymentObject.MachineID = "101.10.11";
                    paymentObject.NetAmount = 0;
                    paymentObject.PaymentDate = DateTime.Now;
                    paymentObject.PaymentType = "I";
                    paymentObject.PreviousDue = 0;
                    paymentObject.PurposeID = "01";
                    paymentObject.PurposeTitle = "Test";
                    paymentObject.ReffDept = "0034";
                    paymentObject.ReffDeptAmount = 0;
                    paymentObject.ReffDeptUnit = "01";
                    paymentObject.RefferedFee = 0;
                    paymentObject.RegistrationNo = "0124";
                    paymentObject.Staff = "012";
                    paymentObject.TransactionNo = "012";
                    paymentObject.VAT = 0;
                    paymentObject.PaymentString = "100000";

                    string vrfy = phrSr.VerifyInPatient(txtRegistrationNo.Text);
                    if (vrfy != "")
                    {
                        MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRegistrationNo.Select();
                        //btnNew.PerformClick();
                        return;
                    }

                    DrugIssue issueObj = this.populateDrugIssueForIPD(paymentObject);

                    string i = phrSr.SaveDrugIssue(issueObj);
                    txtIssueID.Text = i;
                    printReport(i);                    
                    RefreshTreeView();
                    lvDrugIssue.Items.Clear();
                    treeviewPurchaseOrder.Nodes.Clear();
                    btnSave.Enabled = false;
                    List<NursingTree> purchaseorder = phrSr.GetDRID().Select(c => new NursingTree { NursingStationID = c.NurseStationID, NursingStationTitle = c.NurseStationTitle, ReqID = c.DrID }).ToList();
                    Utility.PopulateTreeNursing(treeviewPurchaseOrder, purchaseorder);
                    //if (i == "0")
                    //{
                    //    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //}
                    //else 
                    //{
                    //    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    //}
                   
                
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
            if (this.salesType == "O" || this.salesType == "X")
            {
                if(string.IsNullOrEmpty(txtHCN.Text))
                {
                    MessageBox.Show("Please insert HCN");
                    return;
                }
                try
                {
                    frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                    frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                    frm.ShowDialog();
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
        }

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            

                try
                {
                    DrugIssue issueObj = this.populateDrugIssue((OPDPayment)PaymentObject(payment));

                    string i = phrSr.SaveDrugIssue(issueObj);
                    txtIssueID.Text = i;
                    printReport(i);
                    btnSave.Enabled = false;
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


        private DrugIssue populateDrugIssue(OPDPayment payment)
        {
            DrugIssue dr = new DrugIssue();
            dr.ID = txtIssueID.Text;
            dr.ConsumptionHeadID = "0001";
            dr.ConsumptionID = "0001";
            dr.IssueDate = DateTime.Parse(txtIssueDate.Text);
            dr.IssueType = txtSalesType.Text;
            dr.ReceivedBy = txtReceivedBy.Text;
            dr.Remarks = txtRemarks.Text;
            dr.TransactionType = "CO";
            dr.HCN = txtHCN.Text;
            if (txtSalesType.Text == "O")
            {
                dr.TicketNo = txtPrescriptionNo.Text;
            }
            else
            {
                dr.TicketNo = "P0125";
            }
            dr.RegID = txtRegistrationNo.Text;
            dr.Staff = txtStaff.Text;
            dr.Doctor = txtDoctorID.Text;

            NurseDemandRequisition onurse = new NurseDemandRequisition();
            onurse.DrID = "DR001";
            dr.NurseDemandRequisition = onurse;
            

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            dr.CostCategoryTreeview = ocostcenter;

            Department dpt = new Department();
            dpt.DepartmentID = txtDepartmentID.Text;
            dr.Department = dpt;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = txtDepartmentUnitID.Text;
            dr.DepartmentUnit = dunit;

            EmployeeMaster emp = new EmployeeMaster();
            emp.ID = txtReceivedBy.Text;
            dr.EmployeeMaster = emp;


            Warehouse ph = new Warehouse();
            ph.TypeID = txtPharmacyID.Text;
            dr.Warehouse = ph;
            dr.PharmacyPayment = payment;

            //PurchaseOrder po = new PurchaseOrder();
            //po.ID = cboPurchaseOrder.Text;
            //po.PODate = DateTime.Parse(txtPODate.Text);
            //dr.PurchaseOrder = po;

            
            string drugString = "";

            foreach (ListViewItem itemRow in lvDrugIssue.Items)
            {
                if (Convert.ToInt32(itemRow.SubItems[14].Text) > Convert.ToInt32(itemRow.SubItems[10].Text))
                {
                    drugString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[11].Text + "," + itemRow.SubItems[12].Text + "," + itemRow.SubItems[13].Text;
                    drugString += ";";
                }
            }
            dr.IssueString = drugString;
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            dr.EntryParameter = ep;

            return dr;
        }
        private DrugIssue populateDrugIssueForIPD(OPDPayment payment)
        {
            DrugIssue dr = new DrugIssue();
            dr.ID = txtIssueID.Text;
            dr.ConsumptionHeadID = "0001";
            dr.ConsumptionID = "0001";
            dr.IssueDate = DateTime.Parse(txtIssueDate.Text);
            dr.IssueType = txtSalesType.Text;
            dr.ReceivedBy = txtReceivedBy.Text;
            dr.Remarks = txtRemarks.Text;
            dr.TransactionType = "CO";
            dr.HCN = txtHCNNo.Text;
            dr.TicketNo = "P01";
            dr.RegID = txtRegistrationNo.Text;
            dr.Staff = txtStaff.Text;
            dr.Doctor = txtDoctorID.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            dr.CostCategoryTreeview = ocostcenter;

            NurseDemandRequisition onurse = new NurseDemandRequisition();
            onurse.DrID = txtDRID.Text;
            dr.NurseDemandRequisition = onurse;
            

            Department dpt = new Department();
            dpt.DepartmentID = txtDepartmentID.Text;
            dr.Department = dpt;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = txtDepartmentUnitID.Text;
            dr.DepartmentUnit = dunit;

            EmployeeMaster emp = new EmployeeMaster();
            emp.ID = txtReceivedBy.Text;
            dr.EmployeeMaster = emp;

            Warehouse ph = new Warehouse();
            ph.TypeID = txtPhrID.Text;
            dr.Warehouse = ph;
            dr.PharmacyPayment = payment;

       
            string drugString = "";

            foreach (ListViewItem itemRow in lvDrugIssue.Items)
            {
                if (itemRow.SubItems[14].Text != "0")
                {
                    drugString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[11].Text + "," + itemRow.SubItems[12].Text + "," + itemRow.SubItems[13].Text;
                    drugString += ";";
                }
            }
            dr.IssueString = drugString;
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            dr.EntryParameter = ep;

            return dr;
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
            paymentObject.EntryBy = Utility.UserId;
            paymentObject.EntryDate = payment.EntryDate;
            paymentObject.EntryName = payment.EntryName;
            paymentObject.HCN = payment.HCN;
            paymentObject.LocationID = payment.LocationID;
            paymentObject.MachineID = payment.LocationID;
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
            paymentObject.PaymentString = payment.PaymentString;
            return paymentObject;
        }
        private void ResetField()
        {
            lblGrandTotal.Text = "0";
            labelTotalMedicine.Text = "0";
            lblPatientName.Text = "PatientName";
            levelAgeY.Text = "Age";
            levelDoctor.Text = "Doctor";
            levelDeparment.Text = "Department";
        }

        private void frmDrugIssue_Load(object sender, EventArgs e)
        {

            List<NursingTree> purchaseorder = phrSr.GetDRID().Select(c => new NursingTree { NursingStationID = c.NurseStationID, NursingStationTitle = c.NurseStationTitle, ReqID = c.DrID }).ToList();
            Utility.PopulateTreeNursing(treeviewPurchaseOrder, purchaseorder);

            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = phrSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();
            txtExpireDateMess.Visible = false;
            txtPharmacyID.Text = this.pharmacyID;
            txtSalesType.Text = this.salesType;
            FormatForm(this.salesType);
            FormatGridProd(dgvProduction);
            dgvProduction.Visible = false;
            lvHcnLists.Visible = false;
            FormatGrid();
            FormatGridHCN();
            lblInfo.Visible = false;
        }
        private void FormatForm(string mode)
        {
            switch (mode)
            {
                case "O":
                    txtSalesTypeName.Text = "OPD Sales";
                    txtHCN.Visible = false;
                    txtRegistrationNo.Visible = false;
                    lblNo.Text = "Prescription No";
                    txtPrescriptionNo.Visible = true;
                    txtProductID.Visible = true;
                    txtReceivedBy.Visible = false;
                    lblReceivedBy.Visible = false;
                    smartLabel12.Visible = false;
                    lblPhoneNo.Visible = false;
                    colonPhone.Visible = false;
                    txtPhoneNo.Visible = false;
                    lvHcnLists.Visible = false;
                    txtReceivedBy.Text = "N/A";
                    lblReqRec.Visible = false;
                    txtPrescriptionNo.Text = "";
                    treeviewPurchaseOrder.Visible = false;
                    lblReceivColon.Visible = false;
                    txtGenericNameIPD.Visible = false;
                    //lnklvlPrescibeDrugs.Visible = false;
                    //txtRemarks.Location = txtReceivedBy.Location;
                    //lblRemarks.Location = lblReceivedBy.Location;
                    //lblRemarksColon.Location = smartLabel12.Location;
                    //txtQuatityCompareText.Location = txtRemarks.Location;
                   // ShowHideIndoor(0);
                    txtPrescriptionNo.Select();
                    break;
                case "I":
                    txtSalesTypeName.Text = "IPD Sales";
                    txtRegistrationNo.Top = txtPrescriptionNo.Top;
                    txtRegistrationNo.Left = txtPrescriptionNo.Left;
                    txtRegistrationNo.Size = new Size(txtPrescriptionNo.Size.Width, txtPrescriptionNo.Size.Height);
                    txtGenericNameIPD.Location = txtGenericName.Location;
                    txtHCN.Visible = false;
                    lblPhoneNo.Visible = false;
                    colonPhone.Visible = false;
                    lblGenericName.Visible = true;
                    txtGenericName.Visible = false;
                    txtGenericNameIPD.Visible = true;
                    txtPhoneNo.Visible = false;
                    lvHcnLists.Visible = false;
                    txtPrescriptionNo.Visible = false;
                    treeviewPurchaseOrder.Visible = true;
                    txtProductID.Visible = true;
                    smartLabel12.Visible = true;
                    txtReceivedBy.Visible = true;
                    lblReqRec.Visible = true;
                    txtRegistrationNo.Visible = true;
                    txtRegistrationNo.Text = "";
                    lblNo.Text = "Registration No";
                   // ShowHideIndoor(1);
                    txtRegistrationNo.Select();
                    break;
                case "X":
                    txtSalesTypeName.Text = "Out Case";
                    lblNo.Text = "HCN No";
                    txtRegistrationNo.Visible = false;
                    txtProductID.Visible = true;
                    txtHCN.Visible = true;
                    lblPhoneNo.Visible = true;
                    colonPhone.Visible = true;
                    txtPhoneNo.Visible = true;
                    lvHcnLists.Visible = false;
                    txtGenericNameIPD.Visible = false;
                    txtPrescriptionNo.Visible = false;
                    treeviewPurchaseOrder.Visible = false;
                    txtPrescriptionNo.Text = "";
                    txtReceivedBy.Visible = false;
                    lblReqRec.Visible = false;
                    lblReceivedBy.Visible = false;
                    lblReceivColon.Visible = false;
                    txtReceivedBy.Text = "N/A";
                    txtHCN.Top = txtPrescriptionNo.Top;
                    txtHCN.Left = txtPrescriptionNo.Left;
                    txtHCN.Size = new Size(txtPrescriptionNo.Size.Width, txtPrescriptionNo.Size.Height);
                    txtHCN.Select();
                    break;
            
            }
        }
        private void FormatGridProd(DataGridView dtv)
        {
            //dtv.ColumnHeadersVisible = false;
            dtv.Height = 210;
            dtv.Width = 850;

            dtv.Location = new Point(230,270);
            dtv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Brand Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            colDrugTitle.Width = 190;
            colDrugTitle.Visible = true;
            dtv.Columns.Add(colDrugTitle);
            DataGridViewTextBoxColumn colCompanyID = new DataGridViewTextBoxColumn();
            colCompanyID.Name = "COMPANYID";
            colCompanyID.DataPropertyName = "COMPANYID";
            colCompanyID.Width = 0;
            colCompanyID.Visible = false;
            dtv.Columns.Add(colCompanyID);
            DataGridViewTextBoxColumn colCompanyTitle = new DataGridViewTextBoxColumn();
            colCompanyTitle.Name = "Company";
            colCompanyTitle.DataPropertyName = "COMPANYNAME";
            colCompanyTitle.Width = 220;
            colCompanyTitle.Visible = true;
            dtv.Columns.Add(colCompanyTitle);
            DataGridViewTextBoxColumn colGroupID = new DataGridViewTextBoxColumn();
            colGroupID.Name = "GROUPID";
            colGroupID.DataPropertyName = "GROUPID";
            colGroupID.Width = 0;
            colGroupID.Visible = false;
            dtv.Columns.Add(colGroupID);
            DataGridViewTextBoxColumn colGroupTitle = new DataGridViewTextBoxColumn();
            colGroupTitle.Name = "Generic Name";
            colGroupTitle.DataPropertyName = "GROUPNAME";
            colGroupTitle.Width = 130;
            colGroupTitle.Visible = true;
            dtv.Columns.Add(colGroupTitle);
            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.Name = "TYPEID";
            colTypeID.DataPropertyName = "TYPEID";
            colTypeID.Width = 0;
            colTypeID.Visible = false;
            dtv.Columns.Add(colTypeID);
            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.Name = "Unit Pack";
            colPackName.DataPropertyName = "PACKNAME";            
            colPackName.Width = 0;
            colPackName.Visible = false;
            dtv.Columns.Add(colPackName);
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UNITID";
            colUnitID.DataPropertyName = "UNITID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);
            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            colUnitName.Width = 0;
            colUnitName.Visible = false;
            dtv.Columns.Add(colUnitName);
            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 50;
            dtv.Columns.Add(colUrate);
            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "VAT";
            colVat.DataPropertyName = "VAT";
            colVat.Width = 50;
            dtv.Columns.Add(colVat);
            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Discount";
            colDiscount.DataPropertyName = "Discount";
            colDiscount.Width = 50;
            dtv.Columns.Add(colDiscount);
            DataGridViewTextBoxColumn colStockQty = new DataGridViewTextBoxColumn();
            colStockQty.Name = "StockQty";
            colStockQty.DataPropertyName = "StockQty";
            colStockQty.Width = 80;            
            dtv.Columns.Add(colStockQty);
            dtv.Columns["StockQty"].DefaultCellStyle.ForeColor = Color.Red;
            dtv.Columns["StockQty"].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Bold);

            DataGridViewTextBoxColumn colpharmacy = new DataGridViewTextBoxColumn();
            colpharmacy.Name = "PharmacyName";
            colpharmacy.DataPropertyName = "PharmacyName";
            colpharmacy.Width = 100;
            colpharmacy.Visible = true;
            dtv.Columns.Add(colpharmacy);
        }

        
        private void populateDataToGridDrug(DataGridView dtv, string drugname,string pharmacyid)
        {
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugListStock(drugname,pharmacyid).ToList());
           
            dgvProduction.DataSource = list.Select(data => new
            {
                DRUGID = data.ID,
                DRUGNAME = data.Name,
                COMPANYID = data.DrugCompany.ID,
                COMPANYNAME = data.DrugCompany.Name,
                GROUPID = data.DrugGroup.ID,
                GROUPNAME = data.DrugGroup.Name,
                TYPEID = data.DrugPackType.ID,
                PACKNAME = data.DrugPackType.Name,
                UNITID = data.DrugUnit.ID,
                UNITNAME = data.DrugUnit.Name,
                Rate = data.Slrate,
                VAT = data.VAT,
                Discount = data.Discount,
                //Rackrate = data.Rackrate,
                //Slrate = data.Slrate,
                StockQty = data.StockQty,
                PharmacyName = data.PharmacyName
                
            }).ToList();
            this.dgvProduction.Focus();
          
        }
        private void populateDataToGridDrugByGroup(DataGridView dtv, string groupname)
        {
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugListByGroupName(groupname).ToList());

            dgvProduction.DataSource = list.Select(data => new
            {
                DRUGID = data.ID,
                DRUGNAME = data.Name,
                COMPANYID = data.DrugCompany.ID,
                COMPANYNAME = data.DrugCompany.Name,
                GROUPID = data.DrugGroup.ID,
                GROUPNAME = data.DrugGroup.Name,
                TYPEID = data.DrugPackType.ID,
                PACKNAME = data.DrugPackType.Name,
                UNITID = data.DrugUnit.ID,
                UNITNAME = data.DrugUnit.Name,
                Rate = data.Slrate,
                VAT = data.VAT,
                Discount = data.Discount,
                //Rackrate = data.Rackrate,
                //Slrate = data.Slrate,
                StockQty = data.StockQty,
                PharmacyName = data.PharmacyName

            }).ToList();
            this.dgvProduction.Focus();

        }
        private void populateDataDrugByGroupIPD(DataGridView dtv, string groupname)
        {
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugListByGroupNameForIPD(groupname).ToList());

            dgvProduction.DataSource = list.Select(data => new
            {
                DRUGID = data.ID,
                DRUGNAME = data.Name,
                COMPANYID = data.DrugCompany.ID,
                COMPANYNAME = data.DrugCompany.Name,
                GROUPID = data.DrugGroup.ID,
                GROUPNAME = data.DrugGroup.Name,
                TYPEID = data.DrugPackType.ID,
                PACKNAME = data.DrugPackType.Name,
                UNITID = data.DrugUnit.ID,
                UNITNAME = data.DrugUnit.Name,
                Rate = data.Slrate,
                VAT = data.VAT,
                Discount = data.Discount,
                //Rackrate = data.Rackrate,
                //Slrate = data.Slrate,
                StockQty = data.StockQty,
                PharmacyName = data.PharmacyName

            }).ToList();
            this.dgvProduction.Focus();

        }
      
        private void txtProductionID_KeyDown(object sender, KeyEventArgs e)
        {
          
            
            
        }

        private void dgvProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
         
                setvaluesFromList(dgvProduction, sender);
                AmountSummary();
                txtQuantity.Select();
            
        }
        
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            
            if (dtv.Rows.Count > 0)
            {

                int currentRow = dtv.CurrentRow.Index;
                    currentRow--;   
                    //txtProductID.Text = dtv.CurrentRow.Cells["DRUGID"].Value.ToString();
                    txtProductID.Text = dtv["DRUGID", currentRow+1].Value.ToString();
                    txtProductionName.Text = dtv["Brand Name", currentRow + 1].Value.ToString();
                    //txtProductionName.Text = dtv.CurrentRow.Cells["DRUG NAME"].Value.ToString();
                    txtProductionCompanyID.Text = dtv["COMPANYID",currentRow+1].Value.ToString();
                    txtProdCompName.Text = dtv["Company",currentRow+1].Value.ToString();
                    txtProductionGroupID.Text = dtv["GROUPID",currentRow+1].Value.ToString();
                    txtProdGroupName.Text = dtv["Generic Name", currentRow + 1].Value.ToString();
                    txtGenericName.Text = dtv["Generic Name", currentRow + 1].Value.ToString();
                    txtGenericNameIPD.Text = dtv["Generic Name", currentRow + 1].Value.ToString();
                    txtProductionUnitID.Text = dtv["UNITID",currentRow+1].Value.ToString();
                    txtProdUnitName.Text = dtv["Unit",currentRow+1].Value.ToString();
                    txtProductionPacketID.Text = dtv["TYPEID",currentRow+1].Value.ToString();
                    txtProdPackName.Text = dtv["Unit Pack",currentRow+1].Value.ToString();
                    txtURate.Text = dtv["Rate",currentRow+1].Value.ToString();
                    txtvat.Text = dtv["VAT",currentRow+1].Value.ToString();
                    txtDiscount.Text = dtv["Discount",currentRow+1].Value.ToString();
                    txtQuantity.Text = "0";
                    txtQuatityCompareText.Text = dtv["StockQty",currentRow+1].Value.ToString();

                   
                    dtv.Visible = false;
                    txtProductID.Focus();
                
            }
            else
            {
                dtv.Visible = false;
                txtProductID.Focus();
            }

        }
       

        private void FormatGrid()
        {
           
            lvDrugIssue.Columns.Add("MedicineID", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Brand Name", 250, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("MedicineType", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Type", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("MedicineUnit", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Unit", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("MedicineGroup", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Generic Name", 315, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("MedicineCompany", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Company", 150, HorizontalAlignment.Left);
            
            lvDrugIssue.Columns.Add("Quantity", 70, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Rate", 75, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("VAT", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Disc", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Stock", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Total", 90, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("HCN", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Dept", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Unit", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Doctor", 0, HorizontalAlignment.Left);
            lvDrugIssue.Columns.Add("Pharmacy", 0, HorizontalAlignment.Left);
        }
        private void LoadListNurseStation()
        {
            lvDrugIssue.Items.Clear();
            List<NurseDemandRequisition> onursedemand = phrSr.GetReqDetForIPDIssue(txtDRID.Text).ToList();
            int i = 0;
            foreach(NurseDemandRequisition onurse in onursedemand)
            {
                ListViewItem itm = new ListViewItem(onurse.DrugMaster.ID);                
                itm.SubItems.Add(onurse.DrugMaster.Name);
                itm.SubItems.Add(onurse.DrugMaster.DrugPackType.ID);
                itm.SubItems.Add(onurse.DrugMaster.DrugPackType.Name);
                itm.SubItems.Add(onurse.DrugMaster.DrugUnit.ID);
                itm.SubItems.Add(onurse.DrugMaster.DrugUnit.Name);
                itm.SubItems.Add(onurse.DrugMaster.DrugGroup.ID);
                itm.SubItems.Add(onurse.DrugMaster.DrugGroup.Name);
                itm.SubItems.Add(onurse.DrugMaster.DrugCompany.ID);
                itm.SubItems.Add(onurse.DrugMaster.DrugCompany.Name);
                itm.SubItems.Add(onurse.RemainingQty.ToString());
                itm.SubItems.Add(onurse.DrugMaster.Slrate.ToString());
                itm.SubItems.Add(onurse.DrugMaster.VAT.ToString());
                itm.SubItems.Add(onurse.DrugMaster.Discount.ToString());                    
                itm.SubItems.Add(onurse.StockHelper.StockQty.ToString());              
                itm.SubItems.Add(onurse.DrugMaster.NetAmount.ToString());
                itm.SubItems.Add(onurse.HCN);
                itm.SubItems.Add(onurse.Department);
                itm.SubItems.Add(onurse.Unit);
                itm.SubItems.Add(onurse.Doctor);
                itm.SubItems.Add(onurse.Pharmacy);
                lvDrugIssue.Items.Add(itm);
            
            }
            foreach (ListViewItem lvw in lvDrugIssue.Items)
            {
                //int z = phrSr.VarifyExpireDate(lvw.SubItems[0].Text,lvw.SubItems[20].Text);
                if (lvw.SubItems[14].Text  == "0" )
                {
                    lvw.ForeColor = Color.Red;
                }
                if (phrSr.VarifyExpireDate("0061", lvw.SubItems[0].Text) == 0)
                {
                    lvw.ForeColor = Color.Red;
                    txtExpireDateMess.Visible = true;
                }
            }      
            GrandTotal();  

        }
        private void LoadListView(string productId,string productionName,string productionPacketID,string productionPackName,string unitID,string unitName,string ProductionGroupID,string prodGroupName,string productionCompanyID,string ProdCompName,string Quantity,string rate,string Vat,string discount,string stock)
        {
            

           ListViewItem itm = new ListViewItem(productId);
          
            itm.SubItems.Add(productionName);
            itm.SubItems.Add(productionPacketID);
            itm.SubItems.Add(productionPackName);
            itm.SubItems.Add(unitID);
            itm.SubItems.Add(unitName);
            itm.SubItems.Add(ProductionGroupID);
            itm.SubItems.Add(prodGroupName);
            itm.SubItems.Add(productionCompanyID);
            itm.SubItems.Add(ProdCompName);            
            itm.SubItems.Add(Quantity);
            itm.SubItems.Add(rate);
            itm.SubItems.Add(Vat);
            itm.SubItems.Add(discount);
            itm.SubItems.Add(stock);
            float amountSumamry = float.Parse(Quantity.ToString()) * float.Parse(rate.ToString()) + float.Parse(Vat.ToString()) - float.Parse(discount.ToString());

             double amountSumamry2 = Math.Round(double.Parse(amountSumamry.ToString()),0);
            //Math.Round(amountSumamry,2);
             itm.SubItems.Add(amountSumamry2.ToString());
            //string compareQuantity = "1";
            //itm.SubItems.Add(txtQuatityCompareText.Text);
            lvDrugIssue.Items.Add(itm);

            foreach (ListViewItem lvw in lvDrugIssue.Items)
            {
                if (Convert.ToInt32(lvw.SubItems[14].Text) <= 0)
                {
                    lvw.ForeColor = Color.Red;
                }
                if (this.salesType == "O")
                {
                    if (phrSr.VarifyExpireDate("0007", lvw.SubItems[0].Text) == 0)
                    {
                        lvw.ForeColor = Color.Red;
                        txtExpireDateMess.Visible = true;
                    }
                }
                if (this.salesType == "I")
                {
                    if (phrSr.VarifyExpireDate("0061", lvw.SubItems[0].Text) == 0)
                    {
                        lvw.ForeColor = Color.Red;
                        txtExpireDateMess.Visible = true;
                    }
                }
            }      
             
        }

        private Boolean IsProductDuplicate(ListView vw,string key)
        {
            foreach (ListViewItem itm in vw.Items)
            {
               if (itm.SubItems[0].Text == key)
                {
                    
                    return true;
                }

             }
            return false;
         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtProductionName", "txtURate"};
            Control control = Utility.ReqFieldValidator(this, vf);


            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (this.salesType == "I")
            {
                if (Utility.ParseFloat(txtQuantity.Text) > Utility.ParseFloat(txtReqQty.Text))
                {
                    MessageBox.Show("Sales Quantity must be less than Req Quantity");
                    txtQuantity.Select();
                    return;
                }
            }
             if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(txtQuatityCompareText.Text))
                {
                    MessageBox.Show("Sales Quantity must be less than Stock Quantity");
                    txtQuantity.Select();
                    return;
                }
             
            foreach (ListViewItem lvw in lvDrugIssue.Items)
            {

                if (Utility.ParseFloat(lvw.SubItems[14].Text) > Utility.ParseFloat(lvw.SubItems[14].Text))
                {
                    lvw.ForeColor = Color.Red;
                }               

            }    
            if (IsProductDuplicate(lvDrugIssue,txtProductID.Text))
            {
               
                foreach (ListViewItem itm in lvDrugIssue.Items)
                {
                        if (itm.SubItems[0].Text == txtProductID.Text)
                        {
                            itm.SubItems[10].Text = txtQuantity.Text;
                            itm.SubItems[15].Text = Math.Round(Convert.ToDouble((txtAmountSummary.Text)),0).ToString();
                            GrandTotal();
                            ClearAfterInsert();
                            txtProductID.Select();                            
                        }
                       
                }
                return;                               
            }
            if (txtQuantity.Text == "0" || String.IsNullOrEmpty(txtQuantity.Text) || txtURate.Text == "0")
            {
                MessageBox.Show("Value must not be null or zero");
                txtQuantity.Select();
                return;
            }
            if (this.salesType == "0" || this.salesType == "X" || this.salesType == "I")
            {
                LoadListView(txtProductID.Text, txtProductionName.Text, txtProductionPacketID.Text, txtProdPackName.Text, txtProductionUnitID.Text, txtProdUnitName.Text, txtProductionGroupID.Text, txtProdGroupName.Text, txtProductionCompanyID.Text, txtProdCompName.Text, txtQuantity.Text, txtURate.Text, txtvat.Text, txtDiscount.Text, txtQuatityCompareText.Text);
                GrandTotal();
                ClearAfterInsert();
                txtProductID.Select();
            }

        }
        private void RefreshTreeView()
        {
            LoadListNurseStation();
        }
        //private void Comport()
        //{
        //    SerialPort po = new SerialPort();
        //    if (po.IsOpen)
        //    {
        //        MessageBox.Show("Port is open");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Port is open");
        //    }
        //}
       
        private void GrandTotal()
        {
            labelTotalMedicine.Text = lvDrugIssue.Items.Count.ToString();
            //levelGrandTotal.Text = lvDrugIssue.Items.Count.ToString();
            float sum = 0;
            
                for (int i = 0; i < this.lvDrugIssue.Items.Count; i++)
                {
                    sum += Utility.ParseFloat(this.lvDrugIssue.Items[i].SubItems[15].Text.ToString());
                }
            
            lblGrandTotal.Text = sum.ToString();

        }
        private void ClearAfterInsert()
        {
            txtProductID.Text = string.Empty;
            txtProductionName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtAmountSummary.Text = string.Empty;
            txtQuatityCompareText.Text = string.Empty;

        }
      
        private void txtURate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSalesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void LoadListDrugStock()
        {
            //lvPrescribedMedicine.Items.Clear();
            //List<StockHelper> stk = phrSr.GetDrugsStock().ToString();
            //int i = 0;
            //foreach (StockHelper hlp in stk)
            //{
            //    ListViewItem itm = new ListViewItem(hlp.StockQty.ToString());
            //    lvPrescribedMedicine.Items.Add(itm);
            //}
                
        }
       

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            if (this.salesType == "O" && txtPrescriptionNo.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrescriptionNo.Select(); return;
            }

            else if (this.salesType == "I" && txtRegistrationNo.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidRegistrationNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegistrationNo.Select(); return;

            }
            //|| FormType != "O" 
            //else if ((this.salesType != "O") && (this.salesType != "I") && txtPrescriptionNo.Text == "")
            //{
            //    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPrescriptionNo.Select(); return;

            //}

            if (this.salesType == "O")
            {
                    string vrfy = phrSr.VerifyTicketNo(txtPrescriptionNo.Text, true);
                    if (vrfy != "1")
                    {
                        MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrescriptionNo.Select();
                        //btnNew.PerformClick();
                        return;
                    }

                }
               
                //if ((this.salesType != "O") && (this.salesType == "I") && txtPrescriptionNo.Text != "")
                //{
                //  //   if (VerifyPatientNo(txtHCNNo.Text) == "") { MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Focus(); return; };
                    
                //}
                //if (FormType == "I")
                //{
                //    string vrfy = dmsSR.VerifyInPatient(txtRegistrationNo.Text);
                //    if (vrfy.Length > 0)
                //    {
                //        MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        txtRegistrationNo.Select();
                //        btnNew.PerformClick();
                //        return;
                //    }
                //}
            //if (phrSr.VerifyPatientNo(txtHCNNo.Text) == "") { MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Select(); return; }

            //string searchText = GetSearchText(FormType);
            //Patient pat;
                if (this.salesType == "O" )
                {

                    Ticket tkt = phrSr.GetTicket(txtPrescriptionNo.Text.ToUpper());
                    LoadPatient(tkt);
                    lvDrugIssue.Items.Clear();
                    List<OPDDrugs> mas = phrSr.GetOpdDrugsTkt(txtPrescriptionNo.Text.ToUpper()).ToList();
                    foreach (OPDDrugs dm in mas)
                    {
                        LoadListView(dm.DrugDose.DrugMaster.ID, dm.DrugDose.DrugMaster.Name, dm.DrugDose.DrugMaster.DrugPackType.ID, dm.DrugDose.DrugMaster.DrugPackType.Name, dm.DrugDose.DrugMaster.DrugUnit.ID, dm.DrugDose.DrugMaster.DrugUnit.Name, dm.DrugDose.DrugMaster.DrugGroup.ID, dm.DrugDose.DrugMaster.DrugGroup.Name, dm.DrugDose.DrugMaster.DrugCompany.ID, dm.DrugDose.DrugMaster.DrugCompany.Name, dm.DrugDose.DrugMaster.TotalQty.ToString(), dm.DrugDose.DrugMaster.Slrate.ToString(), dm.DrugDose.DrugMaster.VAT.ToString(), dm.DrugDose.DrugMaster.Discount.ToString(), dm.DrugDose.DrugMaster.StockQty.ToString());
                    }
                    GrandTotal();

                }
                ///  For IPD ////////
                else if (this.salesType == "I")
                {
                    string vrfy = phrSr.VerifyInPatient(txtRegistrationNo.Text);
                    if(vrfy != "")
                    {

                        MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRegistrationNo.Select();
                        //btnNew.PerformClick();
                        return;
                    }
                    InPatient pt = phrSr.GetAdmittedPatient(txtRegistrationNo.Text);
                    
                    LoadPatients(pt);
                    //btnPatientSearch.PerformClick();
                   
                }
                else if (this.salesType == "X")
                {

                    Patient pat = phrSr.GetPatient(txtHCN.Text);
                    LoadOutCasePatient(pat);
                }


        }
        private void LoadPatient(Ticket tkt)
        {
            
             txtHCN.Text = tkt.Patient.HCN;
             lblPatientName.Text = tkt.Patient.Name;

            levelAgeY.Text = Utility.GetAgeStr(short.Parse(tkt.PatientAge.Year.ToString()),short.Parse(tkt.PatientAge.Month.ToString()),short.Parse(tkt.PatientAge.Day.ToString()),short.Parse(tkt.PatientAge.Hour.ToString()));
            
            txtDepartmentID.Text = tkt.TicketDepartment.DepartmentID;
            levelDeparment.Text = tkt.TicketDepartment.DepartmentTitle;
            
            txtDepartmentUnitID.Text = tkt.Patient.DepartmentUnit.UnitId;
            //txtDeptUnitName.Text = tkt.Patient.DepartmentUnit.UnitTitle;

            txtDoctorID.Text = tkt.Doctor.ID;
            levelDoctor.Text = tkt.Doctor.Name;
           
        }
        private void LoadPatients(InPatient tkt)
        {

            txtHCN.Text = tkt.HCN;
            lblPatientName.Text = tkt.Name;

            AH.DUtility.Age age = Utility.CalculateAge(tkt.DOB);
            levelAgeY.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));

            txtDepartmentID.Text = tkt.Department.DepartmentID;
            levelDeparment.Text = tkt.Department.DepartmentTitle;

            txtDepartmentUnitID.Text = tkt.DepartmentUnit.UnitId;
            //txtDeptUnitName.Text = tkt.Patient.DepartmentUnit.UnitTitle;

            txtDoctorID.Text = tkt.Doctor.ID;
            levelDoctor.Text = tkt.Department.DepartmentUnitHead;

        }
        public void LoadOutCasePatient(Patient pat)
        {
            lblPatientName.Text = pat.Name;
            txtHCN.Text = pat.HCN;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            levelAgeY.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));

            txtDepartmentID.Text = "0000";
            levelDeparment.Text = "";
            txtPhoneNo.Text = pat.CellPhone;

            txtDepartmentUnitID.Text = "0000";
            //txtDeptUnitName.Text = tkt.Patient.DepartmentUnit.UnitTitle;

            txtDoctorID.Text = "001";
            levelDoctor.Text = "";

        }
       
        private void txtPrescriptionNo_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void lvDrugIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugIssue.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugIssue.SelectedItems[0];
                txtProductID.Text = itm.SubItems[0].Text;
                txtProductionName.Text = itm.SubItems[1].Text;
                txtProductionPacketID.Text = itm.SubItems[2].Text;
                txtProdPackName.Text = itm.SubItems[3].Text;
                txtProductionUnitID.Text = itm.SubItems[4].Text;
                txtProdUnitName.Text = itm.SubItems[5].Text;
                txtProductionGroupID.Text = itm.SubItems[6].Text;
                txtProdGroupName.Text = itm.SubItems[7].Text;
                txtProductionCompanyID.Text = itm.SubItems[8].Text;
                txtProdCompName.Text = itm.SubItems[9].Text;
                txtQuantity.Text = itm.SubItems[10].Text;
                txtURate.Text = itm.SubItems[11].Text;
                txtvat.Text = itm.SubItems[12].Text;
                txtDiscount.Text = itm.SubItems[13].Text;
                txtQuatityCompareText.Text = itm.SubItems[14].Text; ;
                txtAmountSummary.Text = (Utility.ParseFloat(txtQuantity.Text) * Utility.ParseFloat(txtURate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();
                if (this.salesType == "I")
                {
                    txtHCNNo.Text = itm.SubItems[16].Text;
                    txtDepartmentID.Text = itm.SubItems[17].Text;
                    txtDepartmentUnitID.Text = itm.SubItems[18].Text;
                    txtDoctorID.Text = itm.SubItems[19].Text;
                    txtPhrID.Text = itm.SubItems[20].Text;
                    txtReqQty.Text = itm.SubItems[10].Text;
                    //treeviewPurchaseOrder.SelectedNode.Text = itm.SubItems[16].Text;
                }
            }
            
        }

        private void txtAmountSummary_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtAmountSummary_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void AmountSummary()
        {

            txtAmountSummary.Text = ( Utility.ParseFloat(txtQuantity.Text) * Utility.ParseFloat(txtURate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }

      

        private void txtURate_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }

        private void txtvat_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }

        private void dgvProduction_Enter(object sender, EventArgs e)
        {
            
        }

        private void smartLabel22_Click(object sender, EventArgs e)
        {

        }

        

        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }

        private void smartLabel14_Click(object sender, EventArgs e)
        {

        }

        private void levelDoctor_Click(object sender, EventArgs e)
        {

        }

        private void smartLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtTransactionType_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel9_Click(object sender, EventArgs e)
        {

        }

        private void cboConsumption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        
        
        private void LoadDrugStock(StockHelper stk)
        {
            txtQuatityCompareText.Text = stk.StockQty.ToString();
        }        
        private void printReport(string salesID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.SalesReport;
            vr.issueid = salesID;
            vr.ReportTitle = "Sales Receipt";
            // vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();
        
        }
        private void lvPrescribedMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void pnlMain_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            
            dgvProduction.Visible = false;
        }

        private void lvDrugIssue_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void lvDrugIssue_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgvProduction_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvProduction_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.SalesReport;
            vr.issueid = txtIssueID.Text;
            // vr.ReportTitle = "Patient Registration Statement";
            // vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);

            vr.ViewReport();

            //frmReportViewer vr = new frmReportViewer();
            //vr.selector = ViewerSelector.Admission;
            //vr.PatientNo = txtPatientNo.Text;
            ////vr.TicketNo = txtTicketNo.Text;
            //vr.ReportTitle = "OPD Prescription";
            //vr.ReportSecondParameter = "";
            ////"Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);

            //vr.ViewReport();
        }

        private void btnCloseclk_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem lvItem in lvDrugIssue.SelectedItems)
               {
                    lvDrugIssue.Items.Remove(lvItem);
               }
            GrandTotal();
            //for (int i = 0; i < lvDrugIssue.Items.Count; i++)
            //{
            //    if (lvDrugIssue.Items[i].Selected)
            //    {
            //        lvDrugIssue.Items[i].Remove();
            //        i--;
            //    }
            //}
        }

       

        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduction.Rows[e.RowIndex];


                txtProductID.Text = row.Cells["DRUGID"].Value.ToString();
                //txtProductID.Text = dtv["DRUGID", currentRow].Value.ToString();
                txtProductionName.Text = row.Cells["Brand NAME"].Value.ToString();
                txtProductionCompanyID.Text = row.Cells["COMPANYID"].Value.ToString();
                txtProdCompName.Text = row.Cells["Company"].Value.ToString();
                txtProductionGroupID.Text = row.Cells["GROUPID"].Value.ToString();
                txtProdGroupName.Text = row.Cells["Generic Name"].Value.ToString();
                txtGenericName.Text = row.Cells["Generic Name"].Value.ToString();
                txtGenericNameIPD.Text = row.Cells["Generic Name"].Value.ToString();
                txtProductionUnitID.Text = row.Cells["UNITID"].Value.ToString();
                txtProdUnitName.Text = row.Cells["Unit"].Value.ToString();
                txtProductionPacketID.Text = row.Cells["TYPEID"].Value.ToString();
                txtProdPackName.Text = row.Cells["Unit Pack"].Value.ToString();
                txtURate.Text = row.Cells["Rate"].Value.ToString();
                txtvat.Text = row.Cells["VAT"].Value.ToString();
                txtDiscount.Text = row.Cells["Discount"].Value.ToString();
                txtQuantity.Text = "0";
                txtQuatityCompareText.Text = row.Cells["StockQty"].Value.ToString();

                AmountSummary();
                dgvProduction.Visible = false;
                txtProductID.Focus();

            }
        }

        private void lvDrugIssue_DoubleClick(object sender, EventArgs e)
        {
            //foreach (ListViewItem lvItem in lvDrugIssue.SelectedItems)
            //{
            //    lvDrugIssue.Items.Remove(lvItem);
            //}
            //GrandTotal();
        }

        private void txtReceivedBy_Leave(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = phrSr.GetEmpMaster(txtReceivedBy.Text);
            if (txtReceivedBy.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtReceivedBy.Text != "")
            {
                if (txtReceivedBy.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    //lblDept.Text = oEmpMas.Department.DepartmentID;
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReceivedBy.Select();
                }
            }
        }
        private void txtReceivedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void btnPatientSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.salesType == "O" || this.salesType == "X")
            {
                int number2;

                if (e.KeyCode == Keys.Enter)
                {
                    if (int.TryParse(txtProductID.Text, out number2))
                    {
                        txtQuantity.Select();
                    }
                    else
                    {
                        populateDataToGridDrug(dgvProduction, txtProductID.Text, "0007");
                        dgvProduction.Focus();
                    }
                    if (dgvProduction.Rows.Count == 0)
                    {
                        dgvProduction.Visible = false;
                        txtProductID.Select();
                        txtProductionName.Text = string.Empty;
                        txtQuantity.Text = string.Empty;
                        txtURate.Text = string.Empty;
                        txtvat.Text = string.Empty;
                        txtDiscount.Text = string.Empty;
                        txtAmountSummary.Text = string.Empty;
                        txtQuatityCompareText.Text = string.Empty;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {

                    if (txtProductID.Text.Length == 0)
                    {
                        MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                        return;
                    }
                    populateDataToGridDrug(dgvProduction, txtProductID.Text,"0007");
                    dgvProduction.Focus();
                }
            }
            if (this.salesType == "I")
            {
                int number2;

                if (e.KeyCode == Keys.Enter)
                {
                    if (int.TryParse(txtProductID.Text, out number2))
                    {
                        txtQuantity.Select();
                    }
                    else
                    {
                        populateDataToGridDrug(dgvProduction, txtProductID.Text, "0061");
                        dgvProduction.Focus();
                    }
                    if (dgvProduction.Rows.Count == 0)
                    {
                        dgvProduction.Visible = false;
                        txtProductID.Select();
                        txtProductionName.Text = string.Empty;
                        txtQuantity.Text = string.Empty;
                        txtURate.Text = string.Empty;
                        txtvat.Text = string.Empty;
                        txtDiscount.Text = string.Empty;
                        txtAmountSummary.Text = string.Empty;
                        txtQuatityCompareText.Text = string.Empty;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {

                    if (txtProductID.Text.Length == 0)
                    {
                        MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                        return;
                    }
                    populateDataToGridDrug(dgvProduction, txtProductID.Text, "0061");
                    dgvProduction.Focus();
                }
            }
        }

        private void txtRegistrationNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRegistrationNo.Text.Length == Utility.ScanLength)
            {               
                btnPatientSearch_Click(sender, e);
            }
        }

        private void smartLabel8_Click_1(object sender, EventArgs e)
        {

        }

        private void cboCostCategoey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCostCategoey.SelectedValue != null)
            {

                //CostCenterID,CostcenterName  
                cboCostCenter.DisplayMember = "CostcenterName";
                cboCostCenter.ValueMember = "CostCenterID";
                cboCostCenter.DataSource = phrSr.GetCostcenter("CostcenterTreeview", cboCostCategoey.SelectedValue.ToString(), "").ToList();
            }
        }

        private void smartLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cboCostCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadListFromNurse()
        {
            txtRegistrationNo.DataBindings.Clear();
            txtRegistrationNo.DataBindings.Add("Text", phrSr.GetReqDetForIPDIssue(txtDRID.Text).ToList(), "InPatient.RegistrationNo");
            
            
        }

        private void treeviewPurchaseOrder_AfterSelect(object sender, TreeViewEventArgs e)
        {

            txtDRID.Text = treeviewPurchaseOrder.SelectedNode.Text;
            LoadListNurseStation();
            LoadListFromNurse();
            string vrfy = phrSr.VerifyInPatient(txtRegistrationNo.Text);
            if (vrfy != "")
            {

                MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegistrationNo.Select();
                //btnNew.PerformClick();
                return;
            }
            InPatient pt = phrSr.GetAdmittedPatient(txtRegistrationNo.Text);

            LoadPatients(pt);
           
           
        }

        private void txtRegistrationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {
            
            //foreach (ListViewItem itm in lvDrugIssue.Items)
            //{
            //    txtHCNNo.Text = itm.SubItems[16].Text;
            //    txtDepartmentID.Text = itm.SubItems[17].Text;
            //    txtDepartmentUnitID.Text = itm.SubItems[18].Text;
            //    txtDoctorID.Text = itm.SubItems[19].Text;
            //    txtPhrID.Text = itm.SubItems[20].Text;
            //}
         
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            txtProductionName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtAmountSummary.Text = string.Empty;
            txtQuatityCompareText.Text = string.Empty;
            txtGenericName.Text = string.Empty;
            txtGenericNameIPD.Text = string.Empty;
        }

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pats = phrSr.GetPatientDetails("", txtPhoneNo.Text).ToList();
                LoadListViewHCN();
                foreach (Patient pat in pats)
                {
                    LoadOutCasePatient(pat);
                }
            }
            btnSave.Enabled = true;
        }

        private void txtHCN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }
        private void FormatGridHCN()
        {
            lvHcnLists.CheckBoxes = false;
            lvHcnLists.Columns.Add("HCN", 120, HorizontalAlignment.Left);
            lvHcnLists.Columns.Add("Name", 200, HorizontalAlignment.Left);            
        }
        private void LoadListViewHCN()
        {
            lvHcnLists.Items.Clear();
            pats = phrSr.GetPatientDetails("", txtPhoneNo.Text).ToList();
            int i = 0;
            if (pats.Count > 1)
            {
                lvHcnLists.Visible = true;
                foreach (Patient dg in pats)
                {
                    ListViewItem itm = new ListViewItem(dg.HCN);
                    itm.SubItems.Add(dg.Name);
                    lvHcnLists.Items.Add(itm);
                }

            }
            else
            {
                lvHcnLists.Visible = false;
            }

        }
        private void txtPhoneNo_Leave(object sender, EventArgs e)
        {
                
                pats = phrSr.GetPatientDetails("", txtPhoneNo.Text).ToList();
                LoadListViewHCN();
                foreach (Patient pat in pats)
                {
                    LoadOutCasePatient(pat);
                }
                btnSave.Enabled = true;
            
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductID.Select();
            }

        }

        private void txtPrescriptionNo_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPrescriptionNo_TextChanged_1(object sender, EventArgs e)
        {
            //txtPrescriptionNo.Text = txtPrescriptionNo.Text.ToUpper();
        }

        private void txtHCN_TextChanged(object sender, EventArgs e)
        {
            //txtHCN.Text = Utility.ProperCase(txtHCN.Text);
        }
        public static string ConvertTo_ProperCase(string text)
        {
            TextInfo txt = new CultureInfo("en-US", false).TextInfo;
            return txt.ToUpper(text.ToLower());
        }
        private void txtHCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void txtHCN_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtHCN_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void txtPrescriptionNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void txtPrescriptionNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrescriptionNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void txtPrescriptionNo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtHCN_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHCN.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lvHcnLists.Visible = false;
            lvDrugIssue.Items.Clear();
            btnSave.Enabled = true;
            txtPharmacyID.Text = this.pharmacyID;
            txtSalesType.Text = this.salesType;
            FormatForm(this.salesType);
            txtRegistrationNo.Text = "";
            lblPatientName.Text = string.Empty;
            levelAgeY.Text = string.Empty;
            levelDeparment.Text = string.Empty;
            levelDoctor.Text = string.Empty;
            labelTotalMedicine.Text = "0";
            lblGrandTotal.Text = "0";
        }

        private void txtGenericName_KeyDown(object sender, KeyEventArgs e)
        {
            int number2;

            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtGenericName.Text, out number2))
                {
                    txtQuantity.Select();
                }
                else
                {

                    populateDataToGridDrugByGroup(dgvProduction, txtGenericName.Text);
                    dgvProduction.Focus();
                }
                if (dgvProduction.Rows.Count == 0)
                {
                    dgvProduction.Visible = false;
                    txtGenericName.Select();
                    txtProductionName.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    txtURate.Text = string.Empty;
                    txtvat.Text = string.Empty;
                    txtDiscount.Text = string.Empty;
                    txtAmountSummary.Text = string.Empty;
                    txtQuatityCompareText.Text = string.Empty;
                }
            }
            if (e.KeyCode == Keys.Down)
            {

                if (txtGenericName.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDataToGridDrugByGroup(dgvProduction, txtGenericName.Text);
                dgvProduction.Focus();
            }
        }

        private void txtPhoneNo_KeyUp(object sender, KeyEventArgs e)
        {
            pats = phrSr.GetPatientDetails("", txtPhoneNo.Text).ToList();
            LoadListViewHCN();
            foreach (Patient pat in pats)
            {
                LoadOutCasePatient(pat);
            }
            btnSave.Enabled = true;
        }

        private void lvHcnLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHcnLists.SelectedItems.Count > 0)
            {               
                ListViewItem item = lvHcnLists.SelectedItems[0];
                txtHCN.Text = item.SubItems[0].Text;
                Patient pat = phrSr.GetPatient(txtHCN.Text);
                LoadOutCasePatient(pat);
            }
            else
            {
                txtHCN.Text = string.Empty;
                lvHcnLists.Visible = false;
            }
        }

        private void txtGenericNameIPD_KeyDown(object sender, KeyEventArgs e)
        {
            int number2;

            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtGenericName.Text, out number2))
                {
                    txtQuantity.Select();
                }
                else
                {

                    populateDataDrugByGroupIPD(dgvProduction, txtGenericName.Text);
                    dgvProduction.Focus();
                }
                if (dgvProduction.Rows.Count == 0)
                {
                    dgvProduction.Visible = false;
                    txtGenericName.Select();
                    txtProductionName.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    txtURate.Text = string.Empty;
                    txtvat.Text = string.Empty;
                    txtDiscount.Text = string.Empty;
                    txtAmountSummary.Text = string.Empty;
                    txtQuatityCompareText.Text = string.Empty;
                }
            }
            if (e.KeyCode == Keys.Down)
            {

                if (txtGenericName.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDataDrugByGroupIPD(dgvProduction, txtGenericName.Text);
                dgvProduction.Focus();
            }
        }

        private void txtPrescriptionNo_TextChanged_2(object sender, EventArgs e)
        {
            int x = txtPrescriptionNo.SelectionStart;
            txtPrescriptionNo.Text = ConvertTo_ProperCase(txtPrescriptionNo.Text);
            txtPrescriptionNo.SelectionStart = x;
        }

        private void txtHCN_TextChanged_1(object sender, EventArgs e)
        {
            int x = txtHCN.SelectionStart;
            txtHCN.Text = ConvertTo_ProperCase(txtHCN.Text);
            txtHCN.SelectionStart = x;
        }
        
       
    }
}
