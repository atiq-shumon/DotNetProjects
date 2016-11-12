using AH.DUtility;
using AH.ModuleController.OPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmClinicalFindingsValue : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmClinicalFindingsValue()
        {
            InitializeComponent();
        }
        List<ClinicalFindingsValues> cfv;

        private void frmClinicalFindingsValue_Load(object sender, EventArgs e)
        {
            FormatGrid();
            Loadlistview();
            txtClinicalFindingValName.Select();
        }

        private void FormatGrid()
        {
            lvClinicalFindingsVal.CheckBoxes = false;
            lvClinicalFindingsVal.Columns.Add("Findings Value ID", 150, HorizontalAlignment.Left);
            lvClinicalFindingsVal.Columns.Add("Findings Value Title", 550, HorizontalAlignment.Left);
            lvClinicalFindingsVal.Columns.Add("Findings Value Title Bangla", 0, HorizontalAlignment.Left);
            lvClinicalFindingsVal.Columns.Add("Remarks", 182, HorizontalAlignment.Left);
        }
        private void Loadlistview()
        {
            lvClinicalFindingsVal.Items.Clear();
            cfv = opdSc.GetClinicalFindingsValues().ToList();
            foreach (ClinicalFindingsValues cf in cfv)
            {
                ListViewItem itm = new ListViewItem(cf.FindingsValID);
                itm.SubItems.Add(cf.FindingsValTitle);
                itm.SubItems.Add(cf.FindingsValTitleBeng);
                itm.SubItems.Add(cf.Remarks);
                lvClinicalFindingsVal.Items.Add(itm);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtClinicalFindingValName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvClinicalFindingsVal, 1, txtClinicalFindingValName.Text))
            {
                MessageBox.Show("This Clinical Findings Value is Already Exists");
                return;
            }

            try
            {
                ClinicalFindingsValues cfvs = this.populateClinicalFindingsVal();
                short i = opdSc.SaveClinicalFindingsValue(cfvs);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtClinicalFindingValName.Select();
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
        public ClinicalFindingsValues populateClinicalFindingsVal()
        {
            ClinicalFindingsValues cfvs = new ClinicalFindingsValues();
            cfvs.FindingsValID = txtClinicalFindingValID.Text;
            cfvs.FindingsValTitle = txtClinicalFindingValName.Text;
            cfvs.FindingsValTitleBeng = txtClinicalFindingValNameBang.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            cfvs.EntryParameter = ep;
            return cfvs;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtClinicalFindingValName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ClinicalFindingsValues cfValUpdate = this.populateClinicalFindingsVal();
                short i = opdSc.UpdateClinicalFindingsValue(cfValUpdate);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtClinicalFindingValName.Select();
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

        private void lvClinicalFindingsVal_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (lvClinicalFindingsVal.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                ListViewItem itm = lvClinicalFindingsVal.SelectedItems[0];
                txtClinicalFindingValID.Text = itm.SubItems[0].Text;
                txtClinicalFindingValName.Text = itm.SubItems[1].Text;
                txtClinicalFindingValNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void txtClinicalFindingValName_Leave(object sender, EventArgs e)
        {
            if (txtClinicalFindingValName.Text != "")
            {
                txtClinicalFindingValName.Text = Utility.ProperCase(txtClinicalFindingValName.Text);
            }
        }

        private void txtClinicalFindingValName_TextChanged(object sender, EventArgs e)
        {
            txtClinicalFindingValNameBang.Text = txtClinicalFindingValName.Text;
        }

        private void txtClinicalFindingValName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtClinicalFindingValName.Text != "")
            {
                GetSimilerDiagNameList(lvClinicalFindingsVal, txtClinicalFindingValName.Text);
            }
            else
            {
                Loadlistview();
            }
        }
        private void GetSimilerDiagNameList(ListView lvClinicalFindings, string cfValName)
        {
            IEnumerable<ClinicalFindingsValues> ClinicalFindingsValListLocal;
            if (!(cfValName.Length > 0))
            {
                ClinicalFindingsValListLocal = cfv;
            }
            else
            {
                ClinicalFindingsValListLocal = cfv.Where(x => x.FindingsValTitle.ToLower().Contains(cfValName.ToLower()));
            }

            lvClinicalFindings.Items.Clear();
            foreach (ClinicalFindingsValues cl in ClinicalFindingsValListLocal)
            {
                ListViewItem itm = new ListViewItem(cl.FindingsValID);
                itm.SubItems.Add(cl.FindingsValTitle);
                itm.SubItems.Add(cl.FindingsValTitleBeng);
                itm.SubItems.Add(cl.Remarks);
                lvClinicalFindings.Items.Add(itm);
            }
        }
    }
}
