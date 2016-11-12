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
    public partial class frmEmergencyCollectionEntry : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSR = new DMSSR.DMSWSClient();

        int selRaw;
        private List<EmrCollHead> oCols;
        public frmEmergencyCollectionEntry()
        {
            InitializeComponent();
        }

        private void frmEmergencyBilling_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvCollectionHead);
            FormatAssociatedGrid();

            cboTicketType.DisplayMember = "Value";
            cboTicketType.ValueMember = "Key";
            cboTicketType.DataSource = new BindingSource(Utility.GetPrescriptionTypes(), null);

            cboTicketType.SelectedValue = "E";
            cboTicketType.Enabled = false;

            cboReffOrg.DisplayMember = "Value";
            cboReffOrg.ValueMember = "Key";
            cboReffOrg.DataSource = new BindingSource(dmsSR.GetReffdOrgDic("D"), null);

            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboAdmDeptGrp.DisplayMember = "Value";
            cboAdmDeptGrp.ValueMember = "Key";
            cboAdmDeptGrp.DataSource = new BindingSource(dmsSR.GetDeptGroupDicByType("01"), null);

            cboDepartmentType.Text = "Medical";
            cboDepartmentType.Enabled = false;
            cboDepartmentGroup.Text = "Clinical";
            cboDepartmentGroup.Enabled = false;
            cboDepartment.Text = "Emergency";
            cboDepartment.Enabled = false;
            cboUnit.Text = "--";
            cboUnit.Enabled = false;
            cboAdmDeptGrp.Text = "Clinical";
            //cboAdmDeptGrp.Enabled = false;

            LoadEmeregencyCollectionHead();
        }
        private void LoadDiagnosticFee()
        {
            List<EmergencyMasterRO> Diags = dmsSR.GetEmerDiagBill(txtHCNNo.Text).ToList();
            if (Diags.Count > 0)
            {
                foreach (EmergencyMasterRO Diag in Diags)
                {
                    if (Diag.NetPaid != 0)
                    {
                        dgvAssignedCollectionHead.AllowUserToAddRows = true;
                        selRaw = Convert.ToInt16(dgvAssignedCollectionHead.RowCount.ToString());
                        selRaw = selRaw - 1;
                        dgvAssignedCollectionHead.Rows.Add(1);
                        for (int i = 1; i < dgvAssignedCollectionHead.Rows.Count; i++)
                        {
                            dgvAssignedCollectionHead[0, selRaw].Value = "000049";
                            dgvAssignedCollectionHead[1, selRaw].Value = "Diagnostic Collection Fee";
                            dgvAssignedCollectionHead[2, selRaw].Value = Diag.NetPaid.ToString();
                            dgvAssignedCollectionHead[3, selRaw].Value = Diag.Qty.ToString();
                            dgvAssignedCollectionHead[4, selRaw].Value = "1";
                            dgvAssignedCollectionHead[5, selRaw].Value = "0";
                        }
                        dgvAssignedCollectionHead.AllowUserToAddRows = false;
                        updateCollectedTestSummary(dgvAssignedCollectionHead);
                    }
                }
            }
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
            txtPresentAddress.Text = pat.Present_H_R_B + Utility.CrLf + Utility.CrLf + pat.PresentThana + ", " + pat.PresentDistrict;
            txtMoneyReceiptNo.Text = "";
            chkAdmAdv.Checked = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Patient pat;
            pat = dmsSR.GetPatient(txtHCNNo.Text, "E");
            LoadPatient(pat);           

            LoadAssignedEmergencyCollection();
            //LoadDiagnosticFee();
        }     
        private void txtHCNNo_TextChanged(object sender, EventArgs e)
        {
            txtHCNNo.CharacterCasing = CharacterCasing.Upper;
        }
        private void cboReffOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboReffDoc.DisplayMember = "Value";
            cboReffDoc.ValueMember = "Key";
            cboReffDoc.DataSource = new BindingSource(dmsSR.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
        }

        private void btnAddReffOrg_Click(object sender, EventArgs e)
        {
            frmReffdOrgSetup oReffOrg = new frmReffdOrgSetup();
            oReffOrg.ShowDialog();
        }

        private void btnRefreshOrg_Click(object sender, EventArgs e)
        {
            cboReffOrg.DisplayMember = "Value";
            cboReffOrg.ValueMember = "Key";
            cboReffOrg.DataSource = new BindingSource(dmsSR.GetReffdOrgDic("D"), null);
        }

        private void btnAddReffDoc_Click(object sender, EventArgs e)
        {
            frmReffdDocSetup oReffDoc = new frmReffdDocSetup();
            oReffDoc.ReffOrg = cboReffOrg.SelectedValue.ToString();
            oReffDoc.ShowDialog();
        }

        private void btnRefreshDoc_Click(object sender, EventArgs e)
        {
            cboReffDoc.DisplayMember = "Value";
            cboReffDoc.ValueMember = "Key";
            cboReffDoc.DataSource = new BindingSource(dmsSR.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
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
        private void FormatGrid(DataGridView dgv)
        {
            this.dgvCollectionHead.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCollectionHead.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 50;
            ID.ReadOnly = true;
            dgv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 475;
            Name.ReadOnly = true;
            dgv.Columns.Add(Name);

            DataGridViewTextBoxColumn Fee = new DataGridViewTextBoxColumn();
            Fee.Name = "Fee";
            Fee.DataPropertyName = "Fee";
            Fee.Width = 100;
            Fee.ReadOnly = true;
            dgv.Columns.Add(Fee);

            DataGridViewTextBoxColumn Qty = new DataGridViewTextBoxColumn();
            Qty.Name = "Qty";
            Qty.DataPropertyName = "Qty";
            Qty.Width = 0;
            Qty.ReadOnly = true;
            Qty.Visible = false;
            dgv.Columns.Add(Qty);

            DataGridViewTextBoxColumn PosSrl = new DataGridViewTextBoxColumn();
            PosSrl.Name = "PosSrl";
            PosSrl.DataPropertyName = "PosSrl";
            PosSrl.Width = 0;
            PosSrl.ReadOnly = true;
            PosSrl.Visible = false;
            dgv.Columns.Add(PosSrl);

            DataGridViewTextBoxColumn HeadGrp = new DataGridViewTextBoxColumn();
            HeadGrp.Name = "HeadGrp";
            HeadGrp.DataPropertyName = "HeadGrp";
            HeadGrp.Width = 0;
            HeadGrp.ReadOnly = true;
            HeadGrp.Visible = false;
            dgv.Columns.Add(HeadGrp);
        }

        private void FormatAssociatedGrid()
        {
            dgvAssignedCollectionHead.ColumnCount = 6;
            this.dgvAssignedCollectionHead.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssignedCollectionHead.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            
            dgvAssignedCollectionHead.Columns[0].Name = "ID";
            dgvAssignedCollectionHead.Columns[0].Width = 50;
            dgvAssignedCollectionHead.Columns[0].ReadOnly = true;
            dgvAssignedCollectionHead.Columns[1].Name = "Name";
            dgvAssignedCollectionHead.Columns[1].Width = 450;
            dgvAssignedCollectionHead.Columns[1].ReadOnly = true;
            dgvAssignedCollectionHead.Columns[2].Name = "Fee";
            dgvAssignedCollectionHead.Columns[2].Width = 140;
            dgvAssignedCollectionHead.Columns[2].ReadOnly  = true;
            dgvAssignedCollectionHead.Columns[3].Name = "Qty";
            dgvAssignedCollectionHead.Columns[3].Width = 60;
            dgvAssignedCollectionHead.Columns[3].ReadOnly = true;
            dgvAssignedCollectionHead.Columns[4].Name = "Serial";
            dgvAssignedCollectionHead.Columns[4].Width = 50;
            dgvAssignedCollectionHead.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssignedCollectionHead.Columns[4].ReadOnly = true;
            dgvAssignedCollectionHead.Columns[5].Name = "HeadGroup";
            dgvAssignedCollectionHead.Columns[5].Width = 0;
            dgvAssignedCollectionHead.Columns[5].Visible = false;
            

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssignedCollectionHead.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 60;
        }
        private void LoadEmeregencyCollectionHead()
        {            
            try
            {
                dgvCollectionHead.DataSource = null;
                dgvCollectionHead.Rows.Clear();          
                 int i = 0;
                 oCols = dmsSR.GetEmrCollHead("B", cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
                 if (oCols.Count > 0)
                 {
                     foreach (EmrCollHead oCol in oCols)
                     {                        
                         dgvCollectionHead.Rows.Add(1);
                         dgvCollectionHead.Rows[i].Cells[0].Value = oCol.HeadID;
                         dgvCollectionHead.Rows[i].Cells[1].Value = oCol.HeadTitle; 
                         dgvCollectionHead.Rows[i].Cells[2].Value =oCol.Fee.ToString();
                         dgvCollectionHead.Rows[i].Cells[3].Value ="1";
                         dgvCollectionHead.Rows[i].Cells[4].Value = oCol.PosSerial.ToString();
                         dgvCollectionHead.Rows[i].Cells[5].Value = "0";
                         i = i + 1;
                     }
                     dgvCollectionHead.AllowUserToAddRows = false;                     
                 }
                 else
                 {
                     return;
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

        private void btnAddCollHead_Click(object sender, EventArgs e)
        {
            frmEmeregencyCollectionHead oEmerCollHead = new frmEmeregencyCollectionHead();
            oEmerCollHead.ShowDialog();
        }

        private void btnRefreshCollHead_Click(object sender, EventArgs e)
        {
            LoadEmeregencyCollectionHead();
        }
        private void mAdditem(string HeadID, string HeadTitle, string Fee, string Qty, string Serial, string HeadGroup)
        {
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssignedCollectionHead.RowCount; j++)
            {
                if (dgvAssignedCollectionHead[0, j].Value != null)
                {
                    strDown = dgvAssignedCollectionHead[0, j].Value.ToString();
                }
                if (HeadID == strDown.ToString())
                {
                    blngCheck = true;
                    dgvAssignedCollectionHead[3, j].Value =Convert.ToDouble(dgvAssignedCollectionHead[3, j].Value.ToString()) + Convert.ToDouble(Qty.ToString());
                }
            }
            if (blngCheck == false)
            {
                dgvAssignedCollectionHead.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(dgvAssignedCollectionHead.RowCount.ToString());
                selRaw = selRaw - 1;
                dgvAssignedCollectionHead.Rows.Add(1);
                for (int i = 1; i < dgvAssignedCollectionHead.Rows.Count; i++)
                {
                    dgvAssignedCollectionHead[0, selRaw].Value = HeadID.ToString();
                    dgvAssignedCollectionHead[1, selRaw].Value = HeadTitle.ToString();
                    dgvAssignedCollectionHead[2, selRaw].Value = Fee.ToString();
                    dgvAssignedCollectionHead[3, selRaw].Value = Qty.ToString();
                    dgvAssignedCollectionHead[4, selRaw].Value = Serial.ToString();
                    dgvAssignedCollectionHead[5, selRaw].Value = HeadGroup.ToString();
                }
            }            
            dgvAssignedCollectionHead.AllowUserToAddRows = false;
        }
        private void dgvCollectionHead_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                int i = dgvCollectionHead.CurrentCell.RowIndex;                   
                        mAdditem(dgvCollectionHead[0, i].Value.ToString(), dgvCollectionHead[1, i].Value.ToString(),
                                dgvCollectionHead[2, i].Value.ToString(), dgvCollectionHead[3, i].Value.ToString(),
                                dgvCollectionHead[4, i].Value.ToString(), dgvCollectionHead[5, i].Value.ToString());
                 dgvCollectionHead.AllowUserToAddRows = false;
                 updateCollectedTestSummary(dgvAssignedCollectionHead);
         }

        private void dgvAssignedCollectionHead_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                              
                if (dgvAssignedCollectionHead.Columns[e.ColumnIndex].Name == "btn")
                {
                    if (dgvAssignedCollectionHead.CurrentCell != null)
                    {
                        int selectedIndex = dgvAssignedCollectionHead.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            DialogResult msg = MessageBox.Show("Do You want to Delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (msg == DialogResult.Yes)
                            {
                                dgvAssignedCollectionHead.Rows.RemoveAt(selectedIndex);
                                dgvAssignedCollectionHead.Refresh();
                                updateCollectedTestSummary(dgvAssignedCollectionHead);
                            }
                            else
                            {
                                return;
                            }
                        }
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
        private void dgvAssignedCollectionHead_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3)
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

        private void PopulateDataToGrid(DataGridView dgv, string HeadTitle)
        {
            try
            {
                if (oCols != null)
                {
                    IEnumerable<EmrCollHead> CollectionListLocal;
                    if (!(HeadTitle.Length > 0))
                    {
                        CollectionListLocal = oCols;
                    }
                    else
                    {
                        CollectionListLocal = oCols.Where(x => x.HeadTitle.ToLower().Contains(HeadTitle.ToLower()));
                    }
                    dgv.DataSource = CollectionListLocal.Select(data => new
                    {
                        ID = data.HeadID,
                        Name = data.HeadTitle,
                        Fee = data.Fee,
                        Qty = "1",
                        PosSrl = data.PosSerial,
                        HeadGrp = "0"
                    }).ToList();
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
        private void txtSearchCollHead_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateDataToGrid(dgvCollectionHead, txtSearchCollHead.Text);
            dgvCollectionHead.Refresh();    
        }

        private EmergencyCollectionMR PopulateEmrCollHead()
        {
            string string1 = "";
            EmergencyCollectionMR oEmrCollMR = new EmergencyCollectionMR();
            EmrCollHead oCollHd = new EmrCollHead();
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            Department oDept = new Department();
            DepartmentUnit oDeptUnit = new DepartmentUnit();
            NursingTestOrder oNrs = new NursingTestOrder();
            Doctor oDoctor = new Doctor();
            TestFee oTestFee = new TestFee();
            oTestFee.DiscountType = "0";
            oTestFee.DiscountReff = "0";
            oTestFee.DiscountAuthority = "0";
            oEmrCollMR.test = oTestFee;
            oDoctor.ID = cboReffDoc.SelectedValue.ToString();
            oEmrCollMR.Doctor = oDoctor;
            oNrs.NursingStationID = "12";
            oEmrCollMR.NursingTestOrder = oNrs;
            oEmrCollMR.Remarks = "N/A";

            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oCollHd.DepartmentGroup = oDeptGrp;

            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oCollHd.Department = oDept;

            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oCollHd.DepartmentUnit = oDeptUnit;

            oEmrCollMR.AdmissionID = "0";
            oEmrCollMR.PackageID = "0";

            

            RefdOrg oRefdOrg = new RefdOrg();
            oRefdOrg.OrgID = cboReffOrg.SelectedValue.ToString();
            oEmrCollMR.RefdOrg = oRefdOrg;

            Ticket tkt = new Ticket();
            tkt.TicketNo = txtMoneyReceiptNo.Text.ToString();
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
            pat.RegistrationNo = "0";
            Bed patBed = new Bed();
            patBed.BedID = "0";
            pat.Bed = patBed;           
            pat.StaffID = "0";
            oEmrCollMR.EmrCollHead = oCollHd;

            if (chkAdmAdv.Checked == true)
            {
                oEmrCollMR.IsAdmAdv = "1";

                Department oAdmDept = new Department();
                oAdmDept.DepartmentID = cboAdmDept.SelectedValue.ToString();

                DepartmentGroup oAdmDeptGrp = new DepartmentGroup();
                oAdmDeptGrp.DepartmentGroupID = cboAdmDeptGrp.SelectedValue.ToString();
                oAdmDept.DepartmentGroup = oAdmDeptGrp;

                pat.Department = oAdmDept;

                DepartmentUnit oAdmDeptUnit = new DepartmentUnit();
                oAdmDeptUnit.UnitId = cboAdmUnit.SelectedValue.ToString();
                pat.DepartmentUnit = oAdmDeptUnit;

                Doctor oDoc = new Doctor();
                oDoc.ID = cboadmDoctorID.SelectedValue.ToString();
                pat.Doctor = oDoc;
            }
            if (chkAdmAdv.Checked == false)
            {
                oEmrCollMR.IsAdmAdv = "0";
                Department oAdmDept = new Department();
                oAdmDept.DepartmentID = "0";

                DepartmentGroup oAdmDeptGrp = new DepartmentGroup();
                oAdmDeptGrp.DepartmentGroupID = "0";
                oAdmDept.DepartmentGroup = oAdmDeptGrp;

                pat.Department = oAdmDept;

                DepartmentUnit oAdmDeptUnit = new DepartmentUnit();
                oAdmDeptUnit.UnitId = "0";
                pat.DepartmentUnit = oAdmDeptUnit;

                Doctor oDoc = new Doctor();
                oDoc.ID = "0";
                pat.Doctor = oDoc;
            }

            oEmrCollMR.Patient = pat;

            for (int i = 0; i < dgvAssignedCollectionHead.Rows.Count; i++)
            {
                string1 += dgvAssignedCollectionHead.Rows[i].Cells[0].Value +
                            ":" + dgvAssignedCollectionHead.Rows[i].Cells[2].Value +
                            ":" + dgvAssignedCollectionHead.Rows[i].Cells[3].Value +
                            ":" + dgvAssignedCollectionHead.Rows[i].Cells[4].Value +
                            ":" + dgvAssignedCollectionHead.Rows[i].Cells[5].Value +
                            ":" + ";";
            }
            oEmrCollMR.TestString1 = string1;
            if (lblTestAmountSummary.Text != "")
            {
                oEmrCollMR.NetPaid = Convert.ToDouble(lblTestAmountSummary.Text.ToString());
            }
            else
                oEmrCollMR.NetPaid = 0;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmrCollMR.EntryParameter = ep;

            return oEmrCollMR;

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
            //if (dgvAssignedCollectionHead.Rows.Count == 0)
            //{
            //    MessageBox.Show("No Collection Head is Selected..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            try
            {
                EmergencyCollectionMR oEmerCollMR = this.PopulateEmrCollHead();
                string i = dmsSR.SaveEmergencyCollection(oEmerCollMR);
                txtMoneyReceiptNo.Text = i;
                if (txtMoneyReceiptNo.Text != "")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtHCNNo.Focus();
            clear();
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
            txtSearchCollHead.Text = "";
            txtMoneyReceiptNo.Text = "";
            lblTestCount.Text = "0";
            lblTestAmountSummary.Text = "0";
            dgvAssignedCollectionHead.Rows.Clear();
        }
        private void updateCollectedTestSummary(DataGridView dtv)
        {
            lblTestCount.Text = dtv.RowCount.ToString();
            double sum = 0;
            for (int i = 0; i < dtv.Rows.Count; ++i)
            {
                if (dgvAssignedCollectionHead.Rows[i].Cells[0].Value.ToString() == "000049")
                {
                    sum += Convert.ToDouble(dtv.Rows[i].Cells[2].Value.ToString());
                }
                else
                {
                    sum += Convert.ToDouble(dtv.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(dtv.Rows[i].Cells[3].Value.ToString());
                }
            }
            lblTestAmountSummary.Text = sum.ToString();          
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
                    txtMoneyReceiptNo.Text = oEmr.EmergencyMR;
                    if (Convert.ToInt16(oEmr.IsAdmAdv) == 1)
                    {
                        chkAdmAdv.Checked = true;
                    }
                    if (Convert.ToInt16(oEmr.IsAdmAdv) == 0)
                    {
                        chkAdmAdv.Checked = false;
                    }
                    cboAdmDeptGrp.SelectedValue = oEmr.Patient.Department.DepartmentGroup.DepartmentGroupID;
                    cboAdmDept.SelectedValue = oEmr.Patient.Department.DepartmentID;
                    cboAdmUnit.SelectedValue = oEmr.Patient.DepartmentUnit.UnitId;
                    cboadmDoctorID.SelectedValue = oEmr.Patient.Doctor.ID;
                }
                if(txtMoneyReceiptNo.Text !="")
                {
                    btnAddTest.Enabled = true;
                    btnRefresh.Enabled = true;
                }
                else
                {
                    btnAddTest.Enabled = false;
                    btnRefresh.Enabled = false;
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

        private void txtHCNNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHCNNo.Text.Length == Utility.ScanLength)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void cboAdmDeptGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDeptGrp.SelectedValue != null)
            {
                cboAdmDept.DisplayMember = "Value";
                cboAdmDept.ValueMember = "Key";
                cboAdmDept.DataSource = new BindingSource(dmsSR.GetDepartmentsetupDic(null, cboAdmDeptGrp.SelectedValue.ToString()), null);
            }
        }

        private void cboAdmDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDeptGrp.SelectedValue != null)
            {
                if (cboAdmDept.SelectedValue != "")
                {
                    cboAdmUnit.DisplayMember = "Value";
                    cboAdmUnit.ValueMember = "Key";
                    cboAdmUnit.DataSource = new BindingSource(Utility.VerifyDic(dmsSR.GetDeptUnitDic(cboAdmDeptGrp.SelectedValue.ToString(), cboAdmDept.SelectedValue.ToString())), null);
                }
            }
        }

        private void cboAdmUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDept.SelectedValue != null && cboAdmUnit.SelectedValue != null)
            {
                cboadmDoctorID.ValueMember = "Key";
                cboadmDoctorID.DisplayMember = "Value";
                cboadmDoctorID.DataSource = new BindingSource(dmsSR.GetIPDDoctorsDict(cboAdmDept.SelectedValue.ToString(), cboAdmUnit.SelectedValue.ToString()), null);
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            frmDiagnosticBilling oDiagBilling = new frmDiagnosticBilling("E");
            if (txtHCNNo.Text != "")
            {
                oDiagBilling.HCN = txtHCNNo.Text.ToString();
                oDiagBilling.EmrTicketNo = txtMoneyReceiptNo.Text;
                oDiagBilling.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);

        }
       
    }
}
