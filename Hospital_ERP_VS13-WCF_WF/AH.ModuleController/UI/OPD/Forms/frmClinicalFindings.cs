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
    public partial class frmClinicalFindings : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmClinicalFindings()
        {
            InitializeComponent();
        }
        List<ClinicalFindings> cfs;

        private void frmClinicalFindings_Load(object sender, EventArgs e)
        {
            FindingsGroup();
           // Findings();
            cboFindingsGroup.Select();
            FormatGrid();
            Loadlistview();
            btnEdit.Enabled = false;
      
        }

        private void Findings()
        {
            cboFindingsParents.DisplayMember = "Value";
            cboFindingsParents.ValueMember = "Key";
            cboFindingsParents.DataSource = new BindingSource(opdSc.GetClinicalFindingsDict("D"), null);
        }
        private void FindingsGroup()
        {
            cboFindingsGroup.DisplayMember = "Value";
            cboFindingsGroup.ValueMember = "Key";
            cboFindingsGroup.DataSource = new BindingSource(opdSc.GetClinicalFindingsGroupDict("D"), null);
        }
        private void FormatGrid()
        {
            lvClinicalFindings.CheckBoxes = false;
            lvClinicalFindings.Columns.Add("Group ID", 0, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Parents ID", 0, HorizontalAlignment.Left);
          //  lvClinicalFindings.Columns.Add("Parents Title", 100, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Findings ID", 150, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Findings Title", 550, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Findings Title Bangla", 0, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Findings Level", 0, HorizontalAlignment.Left);
            lvClinicalFindings.Columns.Add("Remarks", 182, HorizontalAlignment.Left);
        }

        private void Loadlistview()
        {
            lvClinicalFindings.Items.Clear();
            cfs = opdSc.GetClinicalFindings().ToList();
            foreach (ClinicalFindings cf in cfs)
            {
                ListViewItem itm = new ListViewItem(cf.FindingsGrpID);
                itm.SubItems.Add(cf.FindingsParentID);
               // itm.SubItems.Add(cf.FindingsParentTitle);
                itm.SubItems.Add(cf.FindingsID);
                itm.SubItems.Add(cf.FindingsTitle);
                itm.SubItems.Add(cf.FindingsTitleBeng);
                itm.SubItems.Add(cf.FindingsLevel);
                itm.SubItems.Add(cf.Remarks);
                lvClinicalFindings.Items.Add(itm);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkParent.Checked == true)
            {
                List<string> vf = new List<string>() { "cboFindingsGroup", "txtClinicalFindingName" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
            }
            if (chkParent.Checked == false)
            {
                List<string> vf = new List<string>() { "cboFindingsGroup", "txtClinicalFindingName", "cboFindingsParents" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
            }
            if (Utility.IsDuplicateFoundInList(lvClinicalFindings, 1, txtClinicalFindingName.Text))
            {
                MessageBox.Show("This Clinical Findings is Already Exists");
                return;
            }

            try
            {
                ClinicalFindings cf = this.populateClinicalFindings();
                short i = opdSc.SaveClinicalFindings(cf);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboFindingsGroup.SelectedIndex = 1;
                    Loadlistview();
                    //Findings();
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
        public ClinicalFindings populateClinicalFindings()
        {
            ClinicalFindings cf = new ClinicalFindings();
            cf.FindingsGrpID = cboFindingsGroup.SelectedValue.ToString();
            cf.FindingsID = txtClinicalFindingID.Text;
            cf.FindingsTitle = txtClinicalFindingName.Text;
            cf.FindingsTitleBeng = txtClinicalFindingNameBang.Text;
            cf.Remarks = txtRemarks.Text;

            //if (chkParent.Checked == true && cboFindingsParents.Text == "--Select--")
            //{
            //    cf.FindingsParentID = "0";
            //    cf.FindingsLevel = "0";
            //}
            //if (chkParent.Checked == true && cboFindingsParents.Text != "--Select--")
            //{
            //    cf.FindingsParentID = "0";
            //    cf.FindingsLevel = "1";
            //}
            if (chkParent.Checked == true)
            {
                cf.FindingsParentID = "0";
                cf.FindingsLevel = "0";
            }

            if (chkParent.Checked == false && cboFindingsParents.Text == "--Select--")
            {
                MessageBox.Show("Please mention the parent for this Clinical Findings", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (chkParent.Checked == false && cboFindingsParents.Text != "--Select--")
            {
                cf.FindingsParentID = cboFindingsParents.SelectedValue.ToString();
                cf.FindingsLevel = "1";
            }

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            cf.EntryParameter = ep;
            return cf;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboFindingsGroup", "txtClinicalFindingName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ClinicalFindings cfUpdate = this.populateClinicalFindings();
                short i = opdSc.UpdateClinicalFindings(cfUpdate);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    cboFindingsGroup.SelectedIndex = 1;
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
            btnEdit.Enabled = false;
        }

        private void lvClinicalFindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            if (lvClinicalFindings.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvClinicalFindings.SelectedItems[0];
                cboFindingsGroup.SelectedValue = itm.SubItems[0].Text;
                cboFindingsParents.SelectedValue = itm.SubItems[1].Text;
                txtClinicalFindingID.Text = itm.SubItems[2].Text;
                txtClinicalFindingName.Text = itm.SubItems[3].Text;
                txtClinicalFindingNameBang.Text = itm.SubItems[4].Text;
                txtRemarks.Text = itm.SubItems[6].Text;

                //lvClinicalFindings.Columns.Add("Group ID", 0, HorizontalAlignment.Left);0
                //lvClinicalFindings.Columns.Add("Parents ID", 0, HorizontalAlignment.Left);1
                ////  lvClinicalFindings.Columns.Add("Parents Title", 100, HorizontalAlignment.Left);
                //lvClinicalFindings.Columns.Add("Findings ID", 150, HorizontalAlignment.Left);2
                //lvClinicalFindings.Columns.Add("Findings Title", 250, HorizontalAlignment.Left);3
                //lvClinicalFindings.Columns.Add("Findings Title Bangla", 250, HorizontalAlignment.Left);4
                //lvClinicalFindings.Columns.Add("Findings Level", 0, HorizontalAlignment.Left);5
                //lvClinicalFindings.Columns.Add("Remarks", 100, HorizontalAlignment.Left);6

            }
        }

        private void txtClinicalFindingName_Leave(object sender, EventArgs e)
        {
            if (txtClinicalFindingName.Text != "")
            {
               // txtClinicalFindingName.Text = Utility.ProperCase(txtClinicalFindingName.Text);
            }
        }

        private void txtClinicalFindingName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtClinicalFindingName.Text != "")
            {
                GetSimilerCFNameList(lvClinicalFindings, txtClinicalFindingName.Text);
            }
            else
            {
                Loadlistview();
            }
        }

        private void txtClinicalFindingName_TextChanged(object sender, EventArgs e)
        {
            txtClinicalFindingNameBang.Text = txtClinicalFindingName.Text;
        }

        private void GetSimilerCFNameList(ListView lvClinicalFindings, string cfName)
        {
            IEnumerable<ClinicalFindings> ClinicalFindingsListLocal;
            if (!(cfName.Length > 0))
            {
                ClinicalFindingsListLocal = cfs;
            }
            else
            {
                ClinicalFindingsListLocal = cfs.Where(x => x.FindingsTitle.ToLower().Contains(cfName.ToLower()));
            }

            lvClinicalFindings.Items.Clear();
            foreach (ClinicalFindings cf in ClinicalFindingsListLocal)
            {
                ListViewItem itm = new ListViewItem(cf.FindingsGrpID);
                itm.SubItems.Add(cf.FindingsParentID);
                itm.SubItems.Add(cf.FindingsID);
                itm.SubItems.Add(cf.FindingsTitle);
                itm.SubItems.Add(cf.FindingsTitleBeng);
                itm.SubItems.Add(cf.FindingsLevel);
                itm.SubItems.Add(cf.Remarks);
                lvClinicalFindings.Items.Add(itm);
            }
        }

        private void cboFindingsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFindingsGroup.SelectedValue != "" && cboFindingsGroup.SelectedValue != null)
            {
                string grpID = cboFindingsGroup.SelectedValue.ToString();
                lvClinicalFindings.Items.Clear();
                cfs = opdSc.GetClinicalFindingByGroup(grpID).ToList();
                foreach (ClinicalFindings cf in cfs)
                {
                    ListViewItem itm = new ListViewItem(cf.FindingsGrpID);
                    itm.SubItems.Add(cf.FindingsParentID);
                    itm.SubItems.Add(cf.FindingsID);
                    itm.SubItems.Add(cf.FindingsTitle);
                    itm.SubItems.Add(cf.FindingsTitleBeng);
                    itm.SubItems.Add(cf.FindingsLevel);
                    itm.SubItems.Add(cf.Remarks);
                    lvClinicalFindings.Items.Add(itm);
                }
                PopulateCombo(cboFindingsParents, cboFindingsGroup.SelectedValue.ToString());
            }
        }

        private void PopulateCombo(ComboBox cbo, string groupID)
        {
            List<ClinicalFindings> oClinicalFindings = new List<ClinicalFindings>();
            var oCFList = (from cfss in cfs where (cfss.FindingsGrpID == cboFindingsGroup.SelectedValue.ToString()) select cfss);
            foreach (ClinicalFindings cf in oCFList)
            {
                ClinicalFindings cflist = new ClinicalFindings();
                cflist.FindingsID = cf.FindingsID;
                cflist.FindingsTitle = cf.FindingsTitle;
                oClinicalFindings.Add(cflist);
            }

            cbo.DataSource = null;
            cbo.Items.Add("--Select--");
            cbo.DisplayMember = "FindingsTitle";
            cbo.ValueMember = "FindingsID";       
            cbo.DataSource = new BindingSource(oClinicalFindings, null);
 
            if (oClinicalFindings.Count <=0)
            {
                cbo.DataSource = null;
                cbo.Items.Add("--Select--");
                cbo.Text = "--Select--";
            }

        }
        private void cboFindingsParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFindingsGroup.SelectedValue != ""  &&  cboFindingsGroup.SelectedValue != null && 
                cboFindingsParents.SelectedValue != "" && cboFindingsParents.SelectedValue != null)
            {
                string grpID = cboFindingsGroup.SelectedValue.ToString();
                string parentID = cboFindingsParents.SelectedValue.ToString();
                lvClinicalFindings.Items.Clear();
                cfs = opdSc.GetClinicalFindingByGroupNParent(grpID, parentID).ToList();
                if (cfs.Count > 0)
                {
                    foreach (ClinicalFindings cf in cfs)
                    {
                        ListViewItem itm = new ListViewItem(cf.FindingsGrpID);
                        itm.SubItems.Add(cf.FindingsParentID);
                        itm.SubItems.Add(cf.FindingsID);
                        itm.SubItems.Add(cf.FindingsTitle);
                        itm.SubItems.Add(cf.FindingsTitleBeng);
                        itm.SubItems.Add(cf.FindingsLevel);
                        itm.SubItems.Add(cf.Remarks);
                        lvClinicalFindings.Items.Add(itm);
                    }
                }
            }
        }
    }
}
