using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmClinicalDiagnosis : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmClinicalDiagnosis()
        {
            InitializeComponent();
        }
        List<ClinicalDiagnosis> clnDiag;
        private void FormatGrid()
        {
            lvClinicalDiag.CheckBoxes = false;
            lvClinicalDiag.Columns.Add("Impression ID", 150, HorizontalAlignment.Left);
            lvClinicalDiag.Columns.Add("Impression Title", 550, HorizontalAlignment.Left);
            lvClinicalDiag.Columns.Add("Impression Title Bangla", 0, HorizontalAlignment.Left);
            lvClinicalDiag.Columns.Add("Remarks", 182, HorizontalAlignment.Left);
        }
        private void Loadlistview()
        {
            lvClinicalDiag.Items.Clear();
            clnDiag = opdSc.GetClinicalDiagnosis().ToList();
            //int i = 0;
            foreach (ClinicalDiagnosis cl in clnDiag)
            {
                ListViewItem itm = new ListViewItem(cl.DiagID);
                itm.SubItems.Add(cl.DiagTitle);
                itm.SubItems.Add(cl.DiagTitleBeng);
                itm.SubItems.Add(cl.Remarks);
                lvClinicalDiag.Items.Add(itm);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDiagName", "txtDiagNameBang"};
            Control control = Utility.ReqFieldValidator(this,vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name)+Utility.Req,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                control.Focus();
                return;   
            }

            if (Utility.IsDuplicateFoundInList(lvClinicalDiag, 1, txtDiagName.Text))
            {
                MessageBox.Show("Impression Already Exists");
                return;
            }

            try
            {
                ClinicalDiagnosis cl = this.populateClinicalDiag();
                short i = opdSc.SaveClinicalDiagnosis(cl);
                if(i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtDiagName.Select();
                    RefreshGrid();
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
            public ClinicalDiagnosis populateClinicalDiag()
            {
                ClinicalDiagnosis cl = new ClinicalDiagnosis();
                cl.DiagID = txtDiagID.Text;
                cl.DiagTitle = txtDiagName.Text;
                cl.DiagTitleBeng = txtDiagNameBang.Text;
                cl.Remarks = txtRemarks.Text;

                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                cl.EntryParameter = ep;
                return cl;
            }

            private void frmClinicalDiagnosis_Load(object sender, EventArgs e)
            {
                FormatGrid();
                Loadlistview();
                btnEdit.Enabled = false;
                txtDiagName.Select();
            }
            private void RefreshGrid()
            {
                Loadlistview();
            }

            private void lvClinicalDiag_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lvClinicalDiag.SelectedItems.Count > 0)
                {
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    ListViewItem itm = lvClinicalDiag.SelectedItems[0];
                    txtDiagID.Text = itm.SubItems[0].Text;
                    txtDiagName.Text = itm.SubItems[1].Text;
                    txtDiagNameBang.Text = itm.SubItems[2].Text;
                    txtRemarks.Text = itm.SubItems[3].Text;
                }
            }

            private void btnEdit_Click(object sender, EventArgs e)
            {

                List<string> vf = new List<string>() { "txtDiagName" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                ////if (Utility.IsDuplicateFoundInList(lvClinicalDiag, 1, txtDiagName.Text))
                ////{
                ////    MessageBox.Show("Already Diagnosis Exists");
                ////    return;
                ////}
                try
                {
                    ClinicalDiagnosis clinicalDiagnosisUpdate = this.populateClinicalDiag();
                    short i = opdSc.UpdateClinicalDiagnosis(clinicalDiagnosisUpdate);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtDiagName.Select();
                        RefreshGrid();
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
                Loadlistview();
                txtDiagName.Select();
            }

            private void lvClinicalDiag_Click(object sender, EventArgs e)
            {
                btnSave.Enabled = false;
            }

            private void txtDiagName_TextChanged(object sender, EventArgs e)
            {
                txtDiagNameBang.Text = txtDiagName.Text;
            }

            private void txtDiagName_KeyUp(object sender, KeyEventArgs e)
            {
                if (txtDiagName.Text != "")
                {
                    GetSimilerDiagNameList(lvClinicalDiag, txtDiagName.Text);
                }
                else
                {
                    Loadlistview();
                }
            }

            private void GetSimilerDiagNameList(ListView lvClinicalDiag, string DiagName)
            {
                IEnumerable<ClinicalDiagnosis> ClinicalDiagnosisListLocal;
                if (!(DiagName.Length > 0))
                {
                    ClinicalDiagnosisListLocal = clnDiag;
                }
                else
                {
                    ClinicalDiagnosisListLocal = clnDiag.Where(x => x.DiagTitle.ToLower().Contains(DiagName.ToLower()));
                }

                lvClinicalDiag.Items.Clear();
                foreach (ClinicalDiagnosis cl in ClinicalDiagnosisListLocal)
                {
                    ListViewItem itm = new ListViewItem(cl.DiagID);
                    itm.SubItems.Add(cl.DiagTitle);
                    itm.SubItems.Add(cl.DiagTitleBeng);
                    itm.SubItems.Add(cl.Remarks);
                    lvClinicalDiag.Items.Add(itm);
                }
            }

            private void txtDiagName_Leave(object sender, EventArgs e)
            {
               
            }       
    }
}
