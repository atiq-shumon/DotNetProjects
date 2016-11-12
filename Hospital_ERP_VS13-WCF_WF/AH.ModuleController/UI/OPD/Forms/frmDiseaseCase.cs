using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;


namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmDiseaseCase : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmDiseaseCase()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        List<DiseaseCase> dpt;
        private void FormatGrid()
        {
            lvDisease.CheckBoxes = false;
            lvDisease.Columns.Add("Disease Group ID", 0, HorizontalAlignment.Center); //0
            lvDisease.Columns.Add("Disease Group", 182, HorizontalAlignment.Center); //1
            lvDisease.Columns.Add("Case ID", 0, HorizontalAlignment.Center); //2 
            lvDisease.Columns.Add("Case Name", 250, HorizontalAlignment.Center); //3
            lvDisease.Columns.Add("Case Name(Bangla)", 0, HorizontalAlignment.Center); //4
            lvDisease.Columns.Add("Department ID", 0, HorizontalAlignment.Center); //5
            lvDisease.Columns.Add("Department", 150, HorizontalAlignment.Center); //6
            lvDisease.Columns.Add("Unit ID", 0, HorizontalAlignment.Center); //7
            lvDisease.Columns.Add("Unit", 200, HorizontalAlignment.Center); //8
            lvDisease.Columns.Add("ShownCheckList", 0, HorizontalAlignment.Center);//9
            lvDisease.Columns.Add("Remarks", 100, HorizontalAlignment.Center);//10
        }
        private void LoadListView()
        {
            lvDisease.Items.Clear();
            dpt = opdSc.GetDiseaseCase().ToList();
            //int i = 0;
            foreach (DiseaseCase di in dpt)
            {
                ListViewItem itm = new ListViewItem(di.DiseaseGrpID);
                itm.SubItems.Add(di.DiseaseGrpTitle);
                itm.SubItems.Add(di.CaseID);
                itm.SubItems.Add(di.CaseTitle);
                itm.SubItems.Add(di.CaseTitleBeng);
                itm.SubItems.Add(di.dept.DepartmentID);
                itm.SubItems.Add(di.dept.DepartmentTitle);
                itm.SubItems.Add(di.deptUnit.UnitId);
                itm.SubItems.Add(di.deptUnit.UnitTitle);
                itm.SubItems.Add(di.ShownCheckList);
                itm.SubItems.Add(di.Remarks);
                lvDisease.Items.Add(itm);
            }
        }

        private void frmDiseaseCase_Load(object sender, EventArgs e)
        {
            DiseaseGroup();
            DepartmentCbo();
            txtCaseName.Select();
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
            
        }
        private void DiseaseGroup()
        {
            cboDiseaseGroup.DisplayMember = "Value";
            cboDiseaseGroup.ValueMember = "Key";
            cboDiseaseGroup.DataSource = new BindingSource(opdSc.getDiseaseGroupDic("D"), null);
        }

        private void DepartmentCbo()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
            }
            else
            {
                return;
            } 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDiseaseGroup", /*"cboDepartment", "cboUnit", */ "txtCaseName", "txtCaseNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvDisease, 1, txtCaseName.Text.ToUpper()))
            {
                MessageBox.Show("Case Name Already Exists!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //string i =  new  PatientRegistrationBLL().Save(txtPatientName.Text, txtFatherName.Text);
            try
            {
                DiseaseCase tdobj = this.PopulateSetup();
                short i = opdSc.SaveDisease(tdobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCaseName.Select();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private DiseaseCase PopulateSetup()
        {
            DiseaseCase tdObj = new DiseaseCase();
            tdObj.DiseaseGrpID = cboDiseaseGroup.SelectedValue.ToString();
            tdObj.CaseID = txtCaseID.Text;
            tdObj.CaseTitle = txtCaseName.Text;
            tdObj.CaseTitleBeng = txtCaseNameBang.Text;

            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();
            tdObj.dept = odept;

            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = cboUnit.SelectedValue.ToString();
            tdObj.deptUnit = deptUnit;
            if (chkShownCheckList.Checked == true)
            {
                tdObj.ShownCheckList = "1";
            }
            if (chkShownCheckList.Checked == false)
            {
                tdObj.ShownCheckList = "0";
            }
            tdObj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tdObj.EntryParameter = ep;

            return tdObj;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboDiseaseGroup", /*"cboDepartment", "cboUnit", */"txtCaseName", "txtCaseNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvDisease, 1, txtCaseName.Text.ToUpper()))
            {
                MessageBox.Show("Case Name Already Exists!!");
                return;
            }
            //string i =  new  PatientRegistrationBLL().Save(txtPatientName.Text, txtFatherName.Text);
           
            try
            {
                DiseaseCase tdobj = this.PopulateSetup();
                short i = opdSc.UpdateDisease(tdobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCaseName.Select();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lvDisease_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDisease.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvDisease.SelectedItems[0];
                cboDiseaseGroup.SelectedValue = itm.SubItems[0].Text.ToString();
                txtCaseID.Text = itm.SubItems[2].Text;
                txtCaseName.Text = itm.SubItems[3].Text;
                txtCaseNameBang.Text = itm.SubItems[4].Text;
                cboDepartment.SelectedValue = itm.SubItems[5].Text.ToString(); ;
                cboUnit.SelectedValue = itm.SubItems[7].Text.ToString();
                txtChkBox.Text = itm.SubItems[9].Text;
                if (txtChkBox.Text == "0")
                {
                    chkShownCheckList.Checked = false;
                }
                if (txtChkBox.Text == "1")
                {
                    chkShownCheckList.Checked = true;
                }
                txtRemarks.Text = itm.SubItems[10].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lvDisease_Click(object sender, EventArgs e)
        {
           // btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DiseaseGroup();
            DepartmentCbo();
            txtCaseName.Select();
            LoadListView();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void txtCaseName_TextChanged(object sender, EventArgs e)
        {
            txtCaseNameBang.Text = txtCaseName.Text;
        }

        private void txtCaseName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCaseName.Text != "")
            {
                GetSimilerCaseNameList(lvDisease, txtCaseName.Text);
            }
            else
            {
                LoadListView();
            }
        }

        private void GetSimilerCaseNameList(ListView lvDisease, string CaseName)
        {
            IEnumerable<DiseaseCase> DiseaseCasesListLocal;
            if (!(CaseName.Length > 0))
            {
                DiseaseCasesListLocal = dpt;
            }
            else
            {
                DiseaseCasesListLocal = dpt.Where(x => x.CaseTitle.ToLower().Contains(CaseName.ToLower()));
            }

            lvDisease.Items.Clear();
            foreach (DiseaseCase di in DiseaseCasesListLocal)
            {
                ListViewItem itm = new ListViewItem(di.DiseaseGrpID);
                itm.SubItems.Add(di.DiseaseGrpTitle);
                itm.SubItems.Add(di.CaseID);
                itm.SubItems.Add(di.CaseTitle);
                itm.SubItems.Add(di.CaseTitleBeng);
                itm.SubItems.Add(di.dept.DepartmentID);
                itm.SubItems.Add(di.dept.DepartmentTitle);
                itm.SubItems.Add(di.deptUnit.UnitId);
                itm.SubItems.Add(di.deptUnit.UnitTitle);
                itm.SubItems.Add(di.ShownCheckList);
                itm.SubItems.Add(di.Remarks);
                lvDisease.Items.Add(itm);
            }
        }

        private void txtCaseName_Leave(object sender, EventArgs e)
        {
            if (txtCaseName.Text != "")
            {
                txtCaseName.Text = Utility.ProperCase(txtCaseName.Text);
            }
        }
       
    }
}
