using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmPurposeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmPurposeSetup()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvPurpose.CheckBoxes = false;

            lvPurpose.Columns.Add("ID", 260, HorizontalAlignment.Center);
            lvPurpose.Columns.Add("Purpose Name", 290, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("Purpose Name(Beng)", 290, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("AccountCode", 0, HorizontalAlignment.Left);
            //lvPurpose.Columns.Add("Account Name",150,HorizontalAlignment.Left);


        }
        private void LoadListView()
        {
            lvPurpose.Items.Clear();

            List<Purpose> purp = accmSc.GetPurpose().ToList();
            int i = 0;
            foreach (Purpose purs in purp)
            {
                ListViewItem itm = new ListViewItem(purs.PurposeID);
                itm.SubItems.Add(purs.PurposeTitle);
                itm.SubItems.Add(purs.PurposeTitleBeng);
                itm.SubItems.Add(purs.COA.AccCode);
                lvPurpose.Items.Add(itm);
            }
        }
        private Purpose PopulatePurpose()
        {
            Purpose prsobj = new Purpose();
            prsobj.PurposeID = txtPurposeID.Text;
            prsobj.PurposeTitle = txtPurposeName.Text;
            prsobj.PurposeTitleBeng = txtPurposeNameBeng.Text;

            COA cdobj = new COA();
            cdobj.AccCode = txtAccCode.Text;
            prsobj.COA = cdobj;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            prsobj.EntryParameter = ep;

            return prsobj;
        }

        private void frmPurposeSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPurposeName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Purpose ps = this.PopulatePurpose();
                short i = accmSc.SavePurposeSetup(ps);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtPurposeName.Focus();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lvPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPurpose.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPurpose.SelectedItems[0];
                txtPurposeID.Text = itm.SubItems[0].Text;
                txtPurposeName.Text = itm.SubItems[1].Text;
                txtPurposeNameBeng.Text = itm.SubItems[2].Text;
                txtAccCode.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPurposeID", "txtPurposeName", "txtPurposeNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (accmSc.VerifyPurpose(txtPurposeID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurposeID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                Purpose ps = this.PopulatePurpose();
                short i = accmSc.UpdatePurpose(ps);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtPurposeName.Focus();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

       

    }
}
