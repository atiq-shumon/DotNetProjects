using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;

using System.Drawing.Imaging;
namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmPunishmentTypeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmPunishmentTypeSetup()
        {
            InitializeComponent();
        }
        private PunishmentType PopulatePunishmentType()
        {
            PunishmentType oPunType = new PunishmentType();
            oPunType.PunID = txtPunishmentID.Text;
            oPunType.PunTitle = txtPunishmentTitle.Text;
            oPunType.PunTitleBeng = txtPunishmentTitleBeng.Text;
            if (chkQuantitive.Checked == true)
            {
                oPunType.isAmount = "1";
            }
            if (chkQuantitive.Checked == false)
            {
                oPunType.isAmount = "0";
            }
            oPunType.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPunType.EntryParameter = ep;
            return oPunType;
        }

        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvPunishementType.CheckBoxes = false;
            lvPunishementType.Columns.Add("Punishment ID", 100, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Punishment Title", 250, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Punishment Title(Bangla)", 250, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("IS Amount", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvPunishementType.Items.Clear();
            List<PunishmentType> oBenTypes = new List<PunishmentType>();
            oBenTypes = hmsSC.GetPunishmentType().ToList();
            foreach (PunishmentType oBenType in oBenTypes)
            {
                ListViewItem itm = new ListViewItem(oBenType.PunID);
                itm.SubItems.Add(oBenType.PunTitle);
                itm.SubItems.Add(oBenType.PunTitleBeng);
                itm.SubItems.Add(oBenType.Remarks);
                itm.SubItems.Add(oBenType.isAmount);
                lvPunishementType.Items.Add(itm);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPunishmentTitle", "txtPunishmentTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvPunishementType, 1, txtPunishmentTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtPunishmentTitle.Focus();
                    return;
                }
                else
                {
                    PunishmentType oPunType = this.PopulatePunishmentType();
                    short i = hmsSC.SavePunishmentType(oPunType);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        RefreshGrid();
                        txtPunishmentTitle.Text = "";
                        txtPunishmentTitleBeng.Text = "";
                        txtRemarks.Text = "";
                        txtPunishmentTitle.Focus();
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
        private void frmPunishmentTypeSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }
        private void lvBenefit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPunishementType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPunishementType.SelectedItems[0];
                txtPunishmentID.Text = itm.SubItems[0].Text;
                txtPunishmentTitle.Text = itm.SubItems[1].Text;
                txtPunishmentTitleBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                if (itm.SubItems[4].Text == "1")
                {
                    chkQuantitive.Checked = true;
                }
                if (itm.SubItems[4].Text == "0")
                {
                    chkQuantitive.Checked = false;
                }
            }        
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPunishmentID", "txtPunishmentTitle", "txtPunishmentTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                PunishmentType oPunType = this.PopulatePunishmentType();
                short i = hmsSC.UpdatePunishmentType(oPunType);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtPunishmentTitle.Text = "";
                    txtPunishmentTitleBeng.Text = "";
                    txtRemarks.Text = "";
                    txtPunishmentTitle.Focus();
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void lvBenefit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtPunishmentTitle_TextChanged(object sender, EventArgs e)
        {
            txtPunishmentTitleBeng.Text = txtPunishmentTitle.Text;
        }

    }
}
