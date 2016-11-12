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


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmHolidayNameSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string TypeID { set; get; }
        public frmHolidayNameSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvHolidayName.CheckBoxes = false;
            lvHolidayName.Columns.Add("Name ID", 100, HorizontalAlignment.Center);
            lvHolidayName.Columns.Add("Type ID", 0, HorizontalAlignment.Left);
            lvHolidayName.Columns.Add("Name Title", 350, HorizontalAlignment.Left);
            lvHolidayName.Columns.Add("Name Title(Beng)", 350, HorizontalAlignment.Left);           
        }
        private void LoadListView(string Type)
        {
            lvHolidayName.Items.Clear();
            List<HolidayName> oNames = hmsSC.GetHolidayName(cboHolidayType.SelectedValue.ToString()).ToList();
            foreach (HolidayName oName in oNames)
            {
                ListViewItem itm = new ListViewItem(oName.NameID);
                itm.SubItems.Add(oName.HolidayType.TypeID);
                itm.SubItems.Add(oName.NameTitle);
                itm.SubItems.Add(oName.NameTitleBeng);              
                lvHolidayName.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            if (cboHolidayType.SelectedValue.ToString() != "")
            {
                LoadListView(cboHolidayType.SelectedValue.ToString());
            }
        }

        private void lvHolidayName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHolidayName.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvHolidayName.SelectedItems[0];
                txtNameID.Text = itm.SubItems[0].Text;
                cboHolidayType.SelectedValue = itm.SubItems[1].Text;
                txtNameTitle.Text = itm.SubItems[2].Text;
                txtNameTitleBeng.Text = itm.SubItems[3].Text;              
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void lvHolidayName_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtNameTitle_TextChanged(object sender, EventArgs e)
        {
            txtNameTitleBeng.Text = txtNameTitle.Text;
        }
        private HolidayName PopulateHolidayName()
        {
            HolidayName oHolidayName = new HolidayName();

            HolidayType oHolidayType = new HolidayType();
            oHolidayType.TypeID = cboHolidayType.SelectedValue.ToString();
            oHolidayName.HolidayType = oHolidayType;

            oHolidayName.NameID = txtNameID.Text;
            oHolidayName.NameTitle = txtNameTitle.Text;
            oHolidayName.NameTitleBeng= txtNameTitleBeng.Text;
            
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oHolidayName.EntryParameter = ep;
            return oHolidayName;

        }

        private void frmHolidayNameSetup_Load(object sender, EventArgs e)
        {
            cboHolidayType.DisplayMember = "Value";
            cboHolidayType.ValueMember = "Key";
            cboHolidayType.DataSource = new BindingSource(hmsSC.GetHolidayTypeDict("D"), null);

            FormatGrid();
            if (TypeID !=null)
            {
                cboHolidayType.SelectedValue = TypeID;
            }
            RefreshGrid();
            txtNameTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboHolidayType", "txtNameTitle", "txtNameTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvHolidayName, 1, txtNameTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtNameTitle.Focus();
                    return;
                }
                else
                {
                    HolidayName oHolidayName = this.PopulateHolidayName();
                    short i = hmsSC.SaveHolidayName(oHolidayName);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtNameTitle.Text = "";
                        txtNameTitleBeng.Text = "";
                        txtNameTitle.Focus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtNameID", "cboHolidayType", "txtNameTitle", "txtNameTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                HolidayName oHolidayName = this.PopulateHolidayName();
                short i = hmsSC.UpdateLHolidayName(oHolidayName);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtNameTitle.Text = "";
                    txtNameTitleBeng.Text = "";
                    txtNameTitle.Focus();
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
        private void cboHolidayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHolidayType.SelectedValue.ToString() != "")
            {
                RefreshGrid();
            }
        }

        private void txtNameTitle_Leave(object sender, EventArgs e)
        {
            txtNameTitle.Text = Utility.ProperCase(txtNameTitle.Text);
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmHolidayTypeSetup oHolidayType = new frmHolidayTypeSetup();
            oHolidayType.ShowDialog();
        }

        private void btnRefreshType_Click(object sender, EventArgs e)
        {
            cboHolidayType.DisplayMember = "Value";
            cboHolidayType.ValueMember = "Key";
            cboHolidayType.DataSource = new BindingSource(hmsSC.GetHolidayTypeDict("D"), null);
        }

    }
}
