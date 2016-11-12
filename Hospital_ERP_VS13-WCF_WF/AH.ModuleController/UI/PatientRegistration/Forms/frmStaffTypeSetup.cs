using AH.DUtility;
using AH.ModuleController.PatientRegistrationSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    public partial class frmStaffTypeSetup : AH.Shared.UI.frmSmartFormStandard
    {

        PatientRegistrationSR.PatientRegistrationWSClient ob = new PatientRegistrationSR.PatientRegistrationWSClient();
        public frmStaffTypeSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtStaffTypeTitle", "txtStaffTypeTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
              StaffType type = this.populateStaffType();
              short i = ob.SaveStaffType(type);
              if (i == 0)
              {
                  MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

              }
              else if (i > 0)
              {
                  MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  btnNew.PerformClick();
              }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private StaffType populateStaffType()
        {
            StaffType stObj = new StaffType();
            stObj.TypeID = txtTypeId.Text;
            stObj.TypeTitle = txtStaffTypeTitle.Text;
            stObj.TypeTitleBeng = txtStaffTypeTitleBeng.Text;
            stObj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            stObj.EntryParameter = ep;

            return stObj;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtStaffTypeTitle", "txtStaffTypeTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                StaffType type = this.populateStaffType();
                short i = ob.UpdateStaffType(type);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnNew.PerformClick();
                    //txtComplaintsTitle.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void frmStaffTypeSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void FormatGrid()
        {
            lvStaffType.Columns.Add("Type ID", 200, HorizontalAlignment.Center);
            lvStaffType.Columns.Add("Type Title", 200, HorizontalAlignment.Left);
            lvStaffType.Columns.Add("Type Title Bangla", 200, HorizontalAlignment.Left);
            lvStaffType.Columns.Add("Remarks", 229, HorizontalAlignment.Left);
        }

        private void LoadListView()
        {
            lvStaffType.Items.Clear();

            List<StaffType> stype = ob.getStaffType().ToList();
            foreach (StaffType st in stype)
            {
                ListViewItem itm = new ListViewItem(st.TypeID);
                itm.SubItems.Add(st.TypeTitle);
                itm.SubItems.Add(st.TypeTitleBeng);
                itm.SubItems.Add(st.Remarks);
                lvStaffType.Items.Add(itm);

            }
        }

        private void lvStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStaffType.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                int index = lvStaffType.SelectedIndices.Count;
                ListViewItem itm = lvStaffType.SelectedItems[0];
                txtTypeId.Text = itm.SubItems[0].Text;
                txtStaffTypeTitle.Text = itm.SubItems[1].Text;
                txtStaffTypeTitleBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTypeId.Text = string.Empty;
            txtStaffTypeTitle.Text = string.Empty;
            txtStaffTypeTitleBeng.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void txtStaffTypeTitle_TextChanged(object sender, EventArgs e)
        {
            txtStaffTypeTitleBeng.Text = txtStaffTypeTitle.Text;
        }
    }
}
