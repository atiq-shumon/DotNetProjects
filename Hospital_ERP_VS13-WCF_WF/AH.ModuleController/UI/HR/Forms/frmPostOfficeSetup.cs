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
    public partial class frmPostOfficeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string District { set; get; }
        public string Thana { set; get; }
        public frmPostOfficeSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvPostOffice.CheckBoxes = false;
            lvPostOffice.Columns.Add("District", 220, HorizontalAlignment.Center);
            lvPostOffice.Columns.Add("Thana", 250, HorizontalAlignment.Left);
            lvPostOffice.Columns.Add("Post Code", 100, HorizontalAlignment.Left);
            lvPostOffice.Columns.Add("Post Office", 250, HorizontalAlignment.Left);
            lvPostOffice.Columns.Add("Old Post Code", 0, HorizontalAlignment.Left);
            lvPostOffice.Columns.Add("Old Post Office", 0, HorizontalAlignment.Left);
        }
        private DistrictThana PopulatePostOfficeSetup()
        {
            DistrictThana oThana = new DistrictThana();
            oThana.DistName = cboDistrict.Text;
            oThana.ThanaName = cboThana.Text;
            oThana.PostCode = txtPostCode.Text;
            oThana.PostOfficeName = txtPostOffice.Text.ToString();
            oThana.OldPostCode = txtPostCodeOld.Text;
            oThana.OldPostOfficeName = txtPostOfficeOld.Text.ToString();
            return oThana;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDistrict", "cboThana", "txtPostCode", "txtPostOffice" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvPostOffice, 3, txtPostOffice.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Post Office Name");
                    txtPostOffice.Focus();
                    return;
                }
                else
                {
                    DistrictThana oPostOffice = this.PopulatePostOfficeSetup();
                    short i = hmsSC.SavePostOffice(oPostOffice);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtPostOffice.Text = "";
                        txtPostOffice.Focus();
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
            if (cboDistrict.Text != "" && cboThana.Text !="")
            {
                LoadListView(cboDistrict.Text.ToString(), cboThana.Text.ToString());
            }
        }
        private void LoadListView(string District,string Thana)
        {
            lvPostOffice.Items.Clear();
            txtPostCode.Text = "";
            txtPostOffice.Text = "";
            List<DistrictThana> oThanas = hmsSC.GetPostOffice(cboDistrict.Text.ToString(), cboThana.Text.ToString()).ToList();
            foreach (DistrictThana oThana in oThanas)
            {
                ListViewItem itm = new ListViewItem(oThana.DistName);
                itm.SubItems.Add(oThana.ThanaName);
                itm.SubItems.Add(oThana.PostCode);
                itm.SubItems.Add(oThana.PostOfficeName);
                itm.SubItems.Add(oThana.PostCode);
                itm.SubItems.Add(oThana.PostOfficeName);
                lvPostOffice.Items.Add(itm);
            }
        }
        private void frmPostOfficeSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();

            cboDistrict.DisplayMember = "Value";
            cboDistrict.ValueMember = "Key";
            cboDistrict.DataSource = new BindingSource(hmsSC.GetDistrictDict("D"), null);

            if(District !=null)
            {
                cboDistrict.Text = District;

                if(Thana !=null)
                {
                    cboThana.Text = Thana;
                }
            }
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrict.Text != "--Select--")
            {
                cboThana.DisplayMember = "Value";
                cboThana.ValueMember = "Key";
                cboThana.DataSource = new BindingSource(hmsSC.GetThanaDict(cboDistrict.Text), null);
            }
        }

        private void lvPostOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPostOffice.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPostOffice.SelectedItems[0];
                cboDistrict.Text = itm.SubItems[0].Text;
                cboThana.Text = itm.SubItems[1].Text;
                txtPostCode.Text = itm.SubItems[2].Text;
                txtPostOffice.Text = itm.SubItems[3].Text;
                txtPostCodeOld.Text = itm.SubItems[4].Text;
                txtPostOfficeOld.Text = itm.SubItems[5].Text;
            }
        }

        private void lvPostOffice_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lvPostOffice.Items.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDistrict", "cboThana", "txtPostCode", "txtPostOffice" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvPostOffice, 3, txtPostOffice.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Post Office Name");
                    txtPostOffice.Focus();
                    return;
                }
                else
                {
                    DistrictThana oPostOffice = this.PopulatePostOfficeSetup();
                    short i = hmsSC.UpdatePostOffice(oPostOffice);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtPostOffice.Text = "";
                        txtPostOffice.Focus();
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

        private void cboThana_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

    }
}
