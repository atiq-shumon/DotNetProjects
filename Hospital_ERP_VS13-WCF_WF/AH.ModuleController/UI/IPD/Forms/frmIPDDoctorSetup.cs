using AH.DUtility;
using AH.ModuleController.IPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmIPDDoctorSetup : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();

        public frmIPDDoctorSetup()
        {
            InitializeComponent();
        }

        private void frmIPDDoctorSetup_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            FormateListView();
            LoadDepartmentType();
            LoadListView();
        }
        #region Department Unit Doctor

        private void LoadDepartmentType()
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
        }
        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(ipdSc.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }
        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(ipdSc.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != null && cboUnit.SelectedValue != null)
            {
                cboDoctor.ValueMember = "Key";
                cboDoctor.DisplayMember = "Value";
                cboDoctor.DataSource = new BindingSource(ipdSc.GetOPDDoctorDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);
            }
        }

        #endregion Department Unit Doctor
        private void FormateListView()
        {
            lvIPDDoctors.Columns.Add("Department Group Type", 0, HorizontalAlignment.Left); //0
            lvIPDDoctors.Columns.Add("Department Group ID", 0, HorizontalAlignment.Left); //1
            lvIPDDoctors.Columns.Add("Department ID", 0, HorizontalAlignment.Left);//2
            lvIPDDoctors.Columns.Add("Department", 100, HorizontalAlignment.Left);//3
            lvIPDDoctors.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);//4
            lvIPDDoctors.Columns.Add("Unit", 150, HorizontalAlignment.Left);//5
            lvIPDDoctors.Columns.Add("Doctor ID", 0, HorizontalAlignment.Left);//6
            lvIPDDoctors.Columns.Add("Doctor", 272, HorizontalAlignment.Left);//7
            lvIPDDoctors.Columns.Add("Visiting Fee", 100, HorizontalAlignment.Left);//8
            lvIPDDoctors.Columns.Add("Doctors Fee", 100, HorizontalAlignment.Left);//9
            lvIPDDoctors.Columns.Add("Remarks", 150, HorizontalAlignment.Left);//10
        }

        private void LoadListView()
        {
            List<IPDDoctor> oIPDDoc = ipdSc.GetIPDDoctorsList().ToList();

            lvIPDDoctors.Items.Clear();

            if (oIPDDoc.Count > 0)
            {
                foreach (IPDDoctor doc in oIPDDoc)
                {
                    ListViewItem itm = new ListViewItem(doc.Department.DepartmentType.TypeID);
                    itm.SubItems.Add(doc.Department.DepartmentGroup.DepartmentGroupID);
                    itm.SubItems.Add(doc.Department.DepartmentID);
                    itm.SubItems.Add(doc.Department.DepartmentTitle);
                    itm.SubItems.Add(doc.DepartmentUnit.UnitId);
                    itm.SubItems.Add(doc.DepartmentUnit.UnitTitle);
                    itm.SubItems.Add(doc.ID);
                    itm.SubItems.Add(doc.Name);
                    itm.SubItems.Add(Convert.ToString(doc.IPDVisitingFee));
                    itm.SubItems.Add(Convert.ToString(doc.DoctorsVisitingFee));
                    itm.SubItems.Add(doc.Remarks);
                    lvIPDDoctors.Items.Add(itm);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtVisitFee.Text = string.Empty;
            txtDrVisitFee.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDoctor", "txtVisitFee", "txtDrVisitFee" };

            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                IPDDoctor oDocSetup = this.populateDoctorsDetail();
                short i = ipdSc.InsertIPDDoctors(oDocSetup);
                if (i == 0)
                {
                    MessageBox.Show("Doctor Setup Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    LoadListView();
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
        private IPDDoctor populateDoctorsDetail()
        {
            IPDDoctor oDoc = new IPDDoctor();

            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            odept.DepartmentGroup = oDeptGrp;

            oDoc.Department = odept;

            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oDoc.DepartmentUnit = deptUnit;

            oDoc.ID = cboDoctor.SelectedValue.ToString();
            oDoc.IPDVisitingFee = Convert.ToDouble( txtVisitFee.Text);
            oDoc.DoctorsVisitingFee = Convert.ToDouble(txtDrVisitFee.Text);

            oDoc.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            oDoc.EntryParameter = ep;

            return oDoc;
        }
       
        private void lvIPDDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIPDDoctors.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;

                ListViewItem itm = lvIPDDoctors.SelectedItems[0];
                cboDepartmentType.SelectedValue = itm.SubItems[0].Text;
                cboDepartmentGroup.SelectedValue = itm.SubItems[1].Text;
                cboDepartment.SelectedValue = itm.SubItems[2].Text;
                cboUnit.SelectedValue = itm.SubItems[4].Text;
                cboDoctor.SelectedValue= itm.SubItems[6].Text;
                txtVisitFee.Text = itm.SubItems[8].Text;
                txtDrVisitFee.Text = itm.SubItems[9].Text;
                txtRemarks.Text = itm.SubItems[10].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDoctor", "txtVisitFee", "txtDrVisitFee" };

            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                IPDDoctor oDocSetup = this.populateDoctorsDetail();
                short i = ipdSc.InsertIPDDoctors(oDocSetup);
                if (i == 0)
                {
                    MessageBox.Show("Doctor Setup Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    LoadListView();
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

    }
}
