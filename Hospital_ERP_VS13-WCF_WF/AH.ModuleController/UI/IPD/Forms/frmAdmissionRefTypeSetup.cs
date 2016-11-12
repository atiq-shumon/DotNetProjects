using AH.DUtility;
using AH.ModuleController.IPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmissionRefTypeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmAdmissionRefTypeSetup()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeTitle", "txtTypeTitleBangla"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
                try
                {
                    if (!(Utility.IsDuplicateFoundInList(lstAdmissionReffSetup,0, txtRdTypeId.Text)))
                    {

                        
                        AdmissionReference oDelType = this.PopulateObject();
                        short i = ipdSc.SaveAdmissionReffType(oDelType);

                        if (i == 1)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            FormatGrid();
                            LoadListView();
                        }
                        else
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Reference Name Already Exist!!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void FormatGrid()
        {
            lstAdmissionReffSetup.Columns.Add("Type ID",80, HorizontalAlignment.Left);
            lstAdmissionReffSetup.Columns.Add("Type Title", 200, HorizontalAlignment.Center);
            lstAdmissionReffSetup.Columns.Add("Type Title Bengali", 300, HorizontalAlignment.Center);
            lstAdmissionReffSetup.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
           
        }

        private void frmAdmissionRefTypeSetup_Load(object sender, EventArgs e)
        {         
                FormatGrid();
                LoadListView();
                txtTypeTitle.Select();         
        }

        private AdmissionReference PopulateObject()
        {
            AdmissionReference oDelType = new AdmissionReference();
            oDelType.Title = txtTypeTitle.Text;
            oDelType.TitleBeng = txtTypeTitleBangla.Text;
            oDelType.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDelType.EntryParameter = ep;


            return oDelType;
        }

        private void LoadListView()
        {
            lstAdmissionReffSetup.Items.Clear();

            List<AdmissionReference> dtps = ipdSc.GetAdmReffType().ToList();
            foreach (AdmissionReference di in dtps)
            {
                ListViewItem itm = new ListViewItem(di.ID);
                itm.SubItems.Add(di.Title);
                itm.SubItems.Add(di.TitleBeng);
                itm.SubItems.Add(di.Remarks);
                lstAdmissionReffSetup.Items.Add(itm);
            }

        }

        private void lstAdmissionReffSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstAdmissionReffSetup.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lstAdmissionReffSetup.SelectedItems[0];
                    txtRdTypeId.Text = itm.SubItems[0].Text;
                    txtTypeTitle.Text = itm.SubItems[1].Text;
                    txtTypeTitleBangla.Text = itm.SubItems[2].Text;
                    txtRemarks.Text = itm.SubItems[3].Text;
                }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRdTypeId", "txtTypeTitle", "txtTypeTitleBangla" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
           
            try
            {
                AdmissionReference tdel = this.PopulateUpdate();
                short i = ipdSc.UpdateAdmissionReffType(tdel);
                if (i == 1)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                    FormatGrid();
                    LoadListView();
                }
                else 
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeTitle.Focus();
                    
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

        private AdmissionReference PopulateUpdate()
        {
            AdmissionReference oDelType = new AdmissionReference();
            oDelType.ID = txtRdTypeId.Text;
            oDelType.Title = txtTypeTitle.Text;
            oDelType.TitleBeng = txtTypeTitleBangla.Text;
            oDelType.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDelType.EntryParameter = ep;


            return oDelType;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTypeTitle_TextChanged(object sender, EventArgs e)
        {
            txtTypeTitleBangla.Text = txtTypeTitle.Text;
        }
    }
}
