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
    public partial class frmThanaSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string District { set; get; }
        public frmThanaSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvThana.CheckBoxes = false;
            lvThana.Columns.Add("District", 300, HorizontalAlignment.Center);
            lvThana.Columns.Add("Thana", 400, HorizontalAlignment.Left);
            lvThana.Columns.Add("OldThana", 0, HorizontalAlignment.Left); 
        }
        private DistrictThana PopulateThanaSetup()
        {
            DistrictThana oThana = new DistrictThana();
            oThana.DistName = cboDistrict.Text;
            oThana.ThanaName = txtThana.Text;
            oThana.OldThanaName = txtThanaOld.Text;
            return oThana;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDistrict", "txtThana" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvThana, 1, txtThana.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtThana.Focus();
                    return;
                }
                else
                {
                    DistrictThana oThana = this.PopulateThanaSetup();
                    short i = hmsSC.SaveThana(oThana);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtThana.Text = "";
                        txtThana.Focus();
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
            LoadListView(cboDistrict.Text.ToString());
        }

        private void frmThanaSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();

            cboDistrict.DisplayMember = "Value";
            cboDistrict.ValueMember = "Key";
            cboDistrict.DataSource = new BindingSource(hmsSC.GetDistrictDict("D"), null);

            if (District != null)
            {
                cboDistrict.Text = District;
            }
        }
        private void LoadListView(string District)
        {
            lvThana.Items.Clear();
            List<DistrictThana> oThanas = hmsSC.GetThana(cboDistrict.Text.ToString()).ToList();
            foreach (DistrictThana oThana in oThanas)
            {
                ListViewItem itm = new ListViewItem(oThana.DistName);
                itm.SubItems.Add(oThana.ThanaName);
                itm.SubItems.Add(oThana.ThanaName);
                lvThana.Items.Add(itm);
            }
        }

        private void lvThana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThana.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvThana.SelectedItems[0];
                cboDistrict.Text = itm.SubItems[0].Text;
                txtThana.Text = itm.SubItems[1].Text;
                txtThanaOld.Text = itm.SubItems[2].Text; 
            }
        }

        private void lvThana_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lvThana.Items.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDistrict", "txtThana" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvThana, 1, txtThana.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtThana.Focus();
                    return;
                }
                else
                {
                    DistrictThana oThana = this.PopulateThanaSetup();
                    short i = hmsSC.UpdateThana(oThana);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtThana.Text = "";
                        txtThana.Focus();
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

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrict.Text != "")
            {
                if (cboDistrict.Text != "--Select--")
                {
                    LoadListView(cboDistrict.Text.ToString());
                }
            }
        }


    }
}
