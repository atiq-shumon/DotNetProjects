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
    public partial class frmRevenueHeadGroup : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        public frmRevenueHeadGroup()
        {
            InitializeComponent();
        }


        #region "Grid"
        private void FormatGrid()
        {
            lvRhgr.CheckBoxes = false;
            lvRhgr.Columns.Add("Type ID", 100, HorizontalAlignment.Center);
            lvRhgr.Columns.Add("Type Name", 400, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Type Name(Bangla)", 0, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvRhgr.Items.Clear();

            List<RevenueHeadGroup> rvhdgr = accmsc.GetRevHdGrps().ToList();
            int i = 0;
            foreach (RevenueHeadGroup rv in rvhdgr)
            {
                ListViewItem itm = new ListViewItem(rv.ID);
                itm.SubItems.Add(rv.Title);
                itm.SubItems.Add(rv.TitleBeng);
                itm.SubItems.Add(rv.Priority.ToString());
                itm.SubItems.Add(rv.Remarks);
                lvRhgr.Items.Add(itm);
            }
        }
        #endregion
        #region "Populated"
        private RevenueHeadGroup PopulateRevgr()
        {
            RevenueHeadGroup revobj = new RevenueHeadGroup();
            revobj.ID = txtRevHdID.Text;
            revobj.Title = txtRevHdName.Text;
            revobj.TitleBeng = txtRevHdName.Text;
            //revobj.Priority = short.Parse(cboPriority.Text);
            revobj.Priority = 1;
            revobj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            revobj.EntryParameter = ep;

            return revobj;
        }
        #endregion
        #region "Form Laod"
        private void frmRevenueHeadGroup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
        }
        #endregion
        #region "Refreshgrid"
        private void RefreshGrid()
        {
            LoadListView();
        }
        #endregion
        #region "Save/Edit"
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRevHdName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                RevenueHeadGroup rvgr = this.PopulateRevgr();
                short i = accmsc.SaveRevenueHeadGr(rvgr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtRevHdName.Focus();
                    RefreshGrid();
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
            List<string> vf = new List<string>() { "txtRevHdID", "txtRevHdName", "txtRevHdNameBeng" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                if(accmsc.VerifyRevHdGr(txtRevHdID.Text) == 0)
                {
                    MessageBox.Show(Utility.VerifyMsg,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtRevHdID.Select();
                    btnNew.PerformClick();
                    return;
                }
                try
                {
                    RevenueHeadGroup rvgr = this.PopulateRevgr();
                    short i = accmsc.UpdateRevHdGr(rvgr);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtRevHdName.Focus();
                        RefreshGrid();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
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
        #endregion
        #region "Selectedchange"
        private void lvRhgr_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (lvRhgr.SelectedItems.Count > 0)
              {
                  btnSave.Enabled = false;
                  btnEdit.Enabled = true;
                  ListViewItem itm = lvRhgr.SelectedItems[0];
                  txtRevHdID.Text = itm.SubItems[0].Text;
                  txtRevHdName.Text = itm.SubItems[1].Text;
                  //txtRevHdNameBeng.Text = itm.SubItems[2].Text;
                  cboPriority.Text = itm.SubItems[3].Text;
                  txtRemarks.Text = itm.SubItems[4].Text;
              }
        }
        #endregion
        #region "New"
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtRevHdName.Focus();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion

    }
}
