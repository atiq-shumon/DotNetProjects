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
using AH.ModuleController.UI.HR.Reports.Viewer;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmBankSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmBankSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvBankInfo.CheckBoxes = false;
            lvBankInfo.Columns.Add("Bank ID", 150, HorizontalAlignment.Center);
            lvBankInfo.Columns.Add("Bank Title", 400, HorizontalAlignment.Left);
            lvBankInfo.Columns.Add("Bank Title(Bangla)", 0, HorizontalAlignment.Left);
            lvBankInfo.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvBankInfo.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }

        private BankInfo PopulateBankSetup()
        {
            BankInfo oBank = new BankInfo();
            oBank.BankID = txtBankID.Text;
            oBank.BankTitle = txtBankTitle.Text;
            oBank.BankTitleBeng = txtBankTitleBeng.Text;
            oBank.Serial = txtSerial.Text;
            oBank.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oBank.EntryParameter = ep;
            return oBank;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtBankTitle", "txtBankTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvBankInfo, 1, txtBankTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Bank Name");
                    txtBankTitle.Focus();
                    return;
                }
                else
                {
                    BankInfo oBank = this.PopulateBankSetup();
                    short i = hmsSC.SaveBankSetup(oBank);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        btnNew.PerformClick();
                        txtBankTitle.Focus();
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
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmBankSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();
            txtBankTitle.Focus();
        }
        private void LoadListView()
        {
            lvBankInfo.Items.Clear();
            List<BankInfo> oLvCancelCauses = hmsSC.GetBankSetup().ToList();
            foreach (BankInfo oBank in oLvCancelCauses)
            {
                ListViewItem itm = new ListViewItem(oBank.BankID);
                itm.SubItems.Add(oBank.BankTitle);
                itm.SubItems.Add(oBank.BankTitleBeng);
                itm.SubItems.Add(oBank.Serial);
                itm.SubItems.Add(oBank.Remarks);
                lvBankInfo.Items.Add(itm);
            }

        }

        private void lvBankInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBankInfo.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBankInfo.SelectedItems[0];
                txtBankID.Text = itm.SubItems[0].Text;
                txtBankTitle.Text = itm.SubItems[1].Text;
                txtBankTitleBeng.Text = itm.SubItems[2].Text;
                txtSerial.Text = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
            }
        }

        private void lvBankInfo_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtBankTitle_TextChanged(object sender, EventArgs e)
        {
            txtBankTitleBeng.Text = txtBankTitle.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtBankID", "txtBankTitle", "txtBankTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvBankInfo, 1, txtBankTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Bank Name");
                    txtBankTitle.Focus();
                    return;
                }
                else
                {
                    BankInfo oBank = this.PopulateBankSetup();
                    short i = hmsSC.UpdateBankSetup(oBank);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        btnNew.PerformClick();
                        txtBankTitle.Focus();
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
    }
}
