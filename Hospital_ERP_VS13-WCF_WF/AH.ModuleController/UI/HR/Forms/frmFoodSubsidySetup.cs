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
    public partial class frmFoodSubsidySetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmFoodSubsidySetup()
        {
            InitializeComponent();
        }

        private void frmFoodSubsidySetup_Load(object sender, EventArgs e)
        {
            cboLevels.DisplayMember = "Value";
            cboLevels.ValueMember = "Key";
            cboLevels.DataSource = new BindingSource(Utility.GetJobLevels(), null);

            FormatGrid();
            LoadListView();         
        }
        private void FormatGrid()
        {
            lvFoodSubsidy.CheckBoxes = false;
            lvFoodSubsidy.Columns.Add("Level", 400, HorizontalAlignment.Left);
            lvFoodSubsidy.Columns.Add("Percent", 150, HorizontalAlignment.Center);
            lvFoodSubsidy.Columns.Add("Serial", 0, HorizontalAlignment.Left);
        }

        private FoodSubsidy PopulateFoodSubsidySetup()
        {
            FoodSubsidy oFoodSubsidySetup = new FoodSubsidy();
            oFoodSubsidySetup.Serial = txtSerial.Text.ToString();
            oFoodSubsidySetup.JobLevel = cboLevels.SelectedValue.ToString();
            oFoodSubsidySetup.Percent = txtPercentage.Text.ToString();
           
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oFoodSubsidySetup.EntryParameter = ep;
            return oFoodSubsidySetup;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboLevels", "txtPercentage" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                FoodSubsidy oFoodSubsidySetup = this.PopulateFoodSubsidySetup();
                short i = hmsSC.SaveFoodSubsidySetup(oFoodSubsidySetup);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        LoadListView();
                        cboLevels.Focus();
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
        private void LoadListView()
        {         
            lvFoodSubsidy.Items.Clear();
            List<FoodSubsidy> oFoodSubsidys = hmsSC.GetFoodSubsidySetup().ToList();
            foreach (FoodSubsidy oFoodSubsidy in oFoodSubsidys)
            {
                ListViewItem itm = new ListViewItem(oFoodSubsidy.JobLevel.ToString());
                itm.SubItems.Add(oFoodSubsidy.Percent.ToString());
                itm.SubItems.Add(oFoodSubsidy.Serial.ToString());
                lvFoodSubsidy.Items.Add(itm);
            }

        }

        private void lvFoodSubsidy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFoodSubsidy.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvFoodSubsidy.SelectedItems[0];
                cboLevels.Text = itm.SubItems[0].Text;
                txtPercentage.Text = itm.SubItems[1].Text;
                txtSerial.Text = itm.SubItems[2].Text;              
            }
        }

        private void lvFoodSubsidy_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboLevels", "txtPercentage", "txtSerial"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                FoodSubsidy oFoodSubsidySetup = this.PopulateFoodSubsidySetup();
                string i = hmsSC.UpdateFoodSubsidySetup(oFoodSubsidySetup);
                if (i != "0")
                {
                    MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i == "0")
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    LoadListView();
                    cboLevels.Focus();
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
