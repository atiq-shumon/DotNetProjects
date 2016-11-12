using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;
using System.Linq;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmAdviceSetup : AH.Shared.UI.frmSmartFormStandard 
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        List<OPDAdvice> oOPDSetupLIST = new List<OPDAdvice>();

        List<OPDAdvice> lsadv;
        public frmAdviceSetup()
        {
            InitializeComponent();
        }
        private void frmAdviceSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
            btnEdit.Enabled = false;
            LoadListView();
            txtAdvice.Select();
        }

        private void txtAdvice_Leave(object sender, EventArgs e)
        {
            if (txtAdvice.Text != "")
            {
                //txtAdvice.Text = Utility.ProperCase(txtAdvice.Text);
            }
        }

        private OPDAdvice PopulateOPDAdvice()
        {
            OPDAdvice oOpd = new OPDAdvice();
            oOpd.AdviceID = txtAdviceID.Text;
            oOpd.AdviceDetails = txtAdvice.Text;

            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oOpd.Department = odept;

            oOpd.Remarks = txtRemarks.Text;

            EntryParameter oep = new EntryParameter();
            oep.EntryBy = Utility.UserId;
            oep.CompanyID = Utility.CompanyID;
            oep.LocationID = Utility.LocationID;
            oep.MachineID = Utility.MachineID;
            oOpd.EntryParameter = oep;

            return oOpd;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtAdvice" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvAdviceSetup, 1, txtAdvice.Text))
            {
                MessageBox.Show("This Advice Already exists!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            short insert = opdSc.AdviceSetupInsert(PopulateOPDAdvice());

            if (oOPDSetupLIST.Count > 0)
                MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadListView();
            btnNew.PerformClick();
        }

        private void LoadListView()
        {
            lvAdviceSetup.Items.Clear();
            lsadv = opdSc.AdviceSetupGET().ToList();
            foreach (OPDAdvice oOPD in lsadv)
            {
                int AdviceID = Convert.ToInt16(oOPD.AdviceID);

                ListViewItem itm = new ListViewItem(oOPD.AdviceID);
                itm.SubItems.Add(Convert.ToString(oOPD.AdviceDetails));
                itm.SubItems.Add(Convert.ToString(oOPD.Department.DepartmentID));
                itm.SubItems.Add(Convert.ToString(oOPD.Remarks));

                lvAdviceSetup.Items.Add(itm);
            }
            this.lvAdviceSetup.View = View.Details;
        }

        private void FormatGrid()
        {
            lvAdviceSetup.Clear();
            lvAdviceSetup.Columns.Add("ID", 80, HorizontalAlignment.Left);
            lvAdviceSetup.Columns.Add("Advice", 500, HorizontalAlignment.Left);
            lvAdviceSetup.Columns.Add("Department", 200, HorizontalAlignment.Left);        
            lvAdviceSetup.Columns.Add("Remarks", 100, HorizontalAlignment.Left);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtAdviceID", "txtAdvice", };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            } 
            short update = opdSc.AdviceSetupUpdate(PopulateOPDAdvice());
            if (update == 1) 
            //if (oOPDSetupLIST.Count > 0)
            {
                MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListView();
            }    
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAdviceID.ReadOnly = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            LoadListView();
            txtAdvice.Select();
        }

        private void lvAdviceSetup_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            if (lvAdviceSetup.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                ListViewItem itm = lvAdviceSetup.SelectedItems[0];
                txtAdviceID.Text = itm.SubItems[0].Text;
                txtAdvice.Text = itm.SubItems[1].Text;
                cboDepartment.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void txtAdvice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAdvice.Text != "") //&& lvComplaints.Items.Count > 0)
            {
                GetSimilerAdviceList(lvAdviceSetup, txtAdvice.Text);
            }
            else
            {
                LoadListView();
            }
        }

        private void GetSimilerAdviceList(ListView lvAdviceSetup, string txtAdviceTitle)
        {
            IEnumerable<OPDAdvice> AdviceListLocal;

            if (!(txtAdviceTitle.Length > 0))
            {
                AdviceListLocal = lsadv;
            }
            else
            {
                AdviceListLocal = lsadv.Where(x => x.AdviceDetails.ToLower().Contains(txtAdviceTitle.ToLower()));
            }
            lvAdviceSetup.Items.Clear();
            foreach (OPDAdvice oOPD in AdviceListLocal)
            {
                int AdviceID = Convert.ToInt16(oOPD.AdviceID);

                ListViewItem itm = new ListViewItem(oOPD.AdviceID);
                itm.SubItems.Add(Convert.ToString(oOPD.AdviceDetails));
                itm.SubItems.Add(Convert.ToString(oOPD.Department.DepartmentID));
                itm.SubItems.Add(Convert.ToString(oOPD.Remarks));

                lvAdviceSetup.Items.Add(itm);
            }
        }
    }
}
