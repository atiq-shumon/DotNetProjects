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
    public partial class frmLeaveType : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();

        public frmLeaveType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeTitle", "txtTypeTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvLeaveType, 1, txtTypeTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtTypeTitle.Focus();
                    return;
                }
                else
                {
                    LeaveType oLvType=this.PopulateLeaveType();
                    short i = hmsSC.SaveLeaveType(oLvType);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtTypeID.Text = "";
                        txtTypeTitle.Text = "";
                        txtTypeTitleBeng.Text = "";
                        txtRemarks.Text = "";
                        txtTypeTitle.Focus();
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


        private void FormatGrid()
        {
            lvLeaveType.CheckBoxes = false;
            lvLeaveType.Columns.Add("Type ID", 150, HorizontalAlignment.Center);
            lvLeaveType.Columns.Add("Type Title", 300, HorizontalAlignment.Left);
            lvLeaveType.Columns.Add("Type Title(Bangla)", 0, HorizontalAlignment.Left);
            lvLeaveType.Columns.Add("Type Flag", 0, HorizontalAlignment.Center);
            lvLeaveType.Columns.Add("Serial", 0, HorizontalAlignment.Center);
            lvLeaveType.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }


        private LeaveType PopulateLeaveType()
        {
            LeaveType oLvType = new LeaveType();
            oLvType.TypeID = txtTypeID.Text;
            oLvType.TypeTitle = txtTypeTitle.Text;
            oLvType.TypeTitleBeng = txtTypeTitleBeng.Text;

            if (chkFlag.Checked == true)
            {
                oLvType.TypeFlag = "1";
            }
            if (chkFlag.Checked == false)
            {
                oLvType.TypeFlag = "0";
            }
            oLvType.Serial = txtsrlNumber.Text;

            oLvType.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oLvType.EntryParameter = ep;
            return oLvType;

        }

        private void frmLeaveType_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            txtTypeTitle.Focus();
        }


        private void LoadListView()
        {
            lvLeaveType.Items.Clear();
            List<LeaveType> oLvTypes = new List<LeaveType>();
            oLvTypes = hmsSC.GetLeaveType().ToList();
            foreach (LeaveType oLvType in oLvTypes)
            {
                ListViewItem itm = new ListViewItem(oLvType.TypeID);
                itm.SubItems.Add(oLvType.TypeTitle);
                itm.SubItems.Add(oLvType.TypeTitleBeng);
                itm.SubItems.Add(oLvType.TypeFlag);
                itm.SubItems.Add(oLvType.Serial);
                itm.SubItems.Add(oLvType.Remarks);
                lvLeaveType.Items.Add(itm);
               
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"txtTypeID", "txtTypeTitle", "txtTypeTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                LeaveType oLvType = this.PopulateLeaveType();
                short i = hmsSC.UpdateLeaveType(oLvType);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtTypeID.Text = "";
                    txtTypeTitle.Text = "";
                    txtTypeTitleBeng.Text = "";
                    txtRemarks.Text = "";
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

        private void lvLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLeaveType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvLeaveType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeTitle.Text = itm.SubItems[1].Text;
                txtTypeTitleBeng.Text = itm.SubItems[2].Text;
                if (Convert.ToInt32(itm.SubItems[3].Text) == 1)
                {
                    chkFlag.Checked = true;
                }
                else
                {
                    chkFlag.Checked = false;
                }
                txtsrlNumber.Text = itm.SubItems[4].Text;
                txtRemarks.Text = itm.SubItems[5].Text;               
            }
        }

        private void lvLeaveType_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtTypeTitle_TextChanged(object sender, EventArgs e)
        {
            txtTypeTitleBeng.Text = txtTypeTitle.Text;
        }

    }
}
