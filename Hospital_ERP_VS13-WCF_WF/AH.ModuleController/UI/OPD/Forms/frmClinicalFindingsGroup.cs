using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPDSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmClinicalFindingsGroup : AH.Shared.UI.frmSmartFormStandard
    {

        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        List<ClinicalFindingsGroup> cfGrp;
        public frmClinicalFindingsGroup()
        {
            InitializeComponent();
        }

        private void frmClinicalFindingsGroup_Load(object sender, EventArgs e)
        {
            DepartmentCbo();
            FormatGrid();
            Loadlistview();
            cboFindingsCategory.Select();

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
        
     
        private void FormatGrid()
        {
            lvClinicalFindingsGrp.CheckBoxes = false;
            lvClinicalFindingsGrp.Columns.Add("Findings Group ID", 0, HorizontalAlignment.Left); //0
            lvClinicalFindingsGrp.Columns.Add("Findings Group Title", 200, HorizontalAlignment.Left); //1
            lvClinicalFindingsGrp.Columns.Add("Findings Group Title Bangla",0, HorizontalAlignment.Left); //2
            lvClinicalFindingsGrp.Columns.Add("Findings Group Categoty", 200, HorizontalAlignment.Left); //3
            lvClinicalFindingsGrp.Columns.Add("Department", 0, HorizontalAlignment.Left); //4
            lvClinicalFindingsGrp.Columns.Add("Department Title", 200, HorizontalAlignment.Left); //5
            lvClinicalFindingsGrp.Columns.Add("Unit", 0, HorizontalAlignment.Left); //6
            lvClinicalFindingsGrp.Columns.Add("Unit Title", 200, HorizontalAlignment.Left); //7
            lvClinicalFindingsGrp.Columns.Add("Remarks", 82, HorizontalAlignment.Left); //8
        }

        private void Loadlistview()
        {
            lvClinicalFindingsGrp.Items.Clear();
            cfGrp = opdSc.GetClinicalFindingsGroups().ToList();
            foreach (ClinicalFindingsGroup cf in cfGrp)
            {
                ListViewItem itm = new ListViewItem(cf.CfGrpID);
                itm.SubItems.Add(cf.CfGrpTitle);
                itm.SubItems.Add(cf.CfGrpTitleBeng);

                if (cf.CfGrpCategory == "G")
                {
                    itm.SubItems.Add("General Examination");
                }
                if(cf.CfGrpCategory == "S")
                {
                    itm.SubItems.Add("Systemic Examination");
                }

                itm.SubItems.Add(cf.Department.DepartmentID);
                itm.SubItems.Add(cf.Department.DepartmentTitle);
                itm.SubItems.Add(cf.DepartmentUnit.UnitId);
                itm.SubItems.Add(cf.DepartmentUnit.UnitTitle);
                itm.SubItems.Add(cf.Remarks);
                lvClinicalFindingsGrp.Items.Add(itm);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboFindingsCategory", "txtClinicalFindingGrpName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvClinicalFindingsGrp, 1, txtClinicalFindingGrpName.Text))
            {
                MessageBox.Show("This Clinical Findings Group is Already Exists");
                return;
            }

            try
            {
                ClinicalFindingsGroup cf = this.populateClinicalFindingsGrp();
                short i = opdSc.SaveClinicalFindingsGrp(cf);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboFindingsCategory.Select();
                    Loadlistview();
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public ClinicalFindingsGroup populateClinicalFindingsGrp()
        {
            ClinicalFindingsGroup cl = new ClinicalFindingsGroup();
            cl.CfGrpID = txtClinicalFindingGrpID.Text;
            cl.CfGrpTitle = txtClinicalFindingGrpName.Text;
            cl.CfGrpTitleBeng = txtClinicalFindingGrpNameBang.Text;

            if (cboFindingsCategory.SelectedIndex == 0)
            {
                cl.CfGrpCategory = "G";
            }
            if (cboFindingsCategory.SelectedIndex == 1)
            {
                cl.CfGrpCategory = "S";
            }
            cl.Remarks = txtRemarks.Text;

            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();
            cl.Department = odept;

            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = cboUnit.SelectedValue.ToString();
            cl.DepartmentUnit = deptUnit;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            cl.EntryParameter = ep;
            return cl;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboFindingsCategory", "txtClinicalFindingGrpName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ClinicalFindingsGroup cfGrpUpdate = this.populateClinicalFindingsGrp();
                short i = opdSc.UpdateClinicalFindingsGrp(cfGrpUpdate);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboFindingsCategory.Select();
                    Loadlistview();
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void lvClinicalFindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (lvClinicalFindingsGrp.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                ListViewItem itm = lvClinicalFindingsGrp.SelectedItems[0];
                txtClinicalFindingGrpID.Text = itm.SubItems[0].Text;
                txtClinicalFindingGrpName.Text = itm.SubItems[1].Text;
                txtClinicalFindingGrpNameBang.Text = itm.SubItems[2].Text;

                if (itm.SubItems[3].Text == "General Examination")
                {
                    cboFindingsCategory.SelectedIndex = 0;
                }
                if (itm.SubItems[3].Text == "Systemic Examination")
                {
                    cboFindingsCategory.SelectedIndex = 1;
                }
                cboFindingsCategory.SelectedText = itm.SubItems[3].Text;

                cboDepartment.SelectedValue = itm.SubItems[4].Text;
                cboUnit.SelectedValue = itm.SubItems[6].Text;
                txtRemarks.Text = itm.SubItems[8].Text;
            }
        }

        private void txtClinicalFindingGrpName_Leave(object sender, EventArgs e)
        {
            if (txtClinicalFindingGrpName.Text != "")
            {
                txtClinicalFindingGrpName.Text = Utility.ProperCase(txtClinicalFindingGrpName.Text);
            }
        }

        private void txtClinicalFindingGrpName_TextChanged(object sender, EventArgs e)
        {
             txtClinicalFindingGrpNameBang.Text = txtClinicalFindingGrpName.Text;
        }

        private void txtClinicalFindingGrpName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtClinicalFindingGrpName.Text != "")
            {
                GetSimilerDiagNameList(lvClinicalFindingsGrp, txtClinicalFindingGrpName.Text);
            }
            else
            {
                Loadlistview();
            }
        }

        private void GetSimilerDiagNameList(ListView lvClinicalFindingsGrp, string cfGrpName)
        {
            IEnumerable<ClinicalFindingsGroup> ClinicalFindingsListLocal;
            if (!(cfGrpName.Length > 0))
            {
                ClinicalFindingsListLocal = cfGrp;
            }
            else
            {
                ClinicalFindingsListLocal = cfGrp.Where(x => x.CfGrpTitle.ToLower().Contains(cfGrpName.ToLower()));
            }

            lvClinicalFindingsGrp.Items.Clear();
            foreach (ClinicalFindingsGroup cl in ClinicalFindingsListLocal)
            {
                ListViewItem itm = new ListViewItem(cl.CfGrpID);
                itm.SubItems.Add(cl.CfGrpTitle);
                itm.SubItems.Add(cl.CfGrpTitleBeng);
                itm.SubItems.Add(cl.CfGrpCategory);
                itm.SubItems.Add(cl.Remarks);
                lvClinicalFindingsGrp.Items.Add(itm);
            }
        }
  
    }
}
