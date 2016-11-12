using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmAssetsUser : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmAssetsUser()
        {
            InitializeComponent();
        }
        
     
        private void frmAssetsUser_Load(object sender, EventArgs e)
        {
            cboDepartment.ValueMember = "Key";
            cboDepartment.DisplayMember = "Value";
            cboDepartment.DataSource = new BindingSource(atms.GetDepartment("HrsDep", ""), null);
        }

        private void GenerateUser()
        {
            lvwAssetsUser.Items.Clear();
            long lngStartingNo= Convert.ToInt32(txtStartingNo.Text);
            long lngTotalNoUser = lngStartingNo+Convert.ToInt32(txtTotalNoUser.Text);
            for (long i=lngStartingNo;i < lngTotalNoUser ;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = txtPrefix.Text + i;
                lvi.SubItems.Add(i.ToString());
                lvwAssetsUser.Items.Add(lvi);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateUser();
        }
        private bool validationfields()
        {
            if (cboDepartment.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }
        private AssetsUser  PopulatedAssetsuser()
        {
            AssetsUser objassets = new AssetsUser();
            objassets.formName = "Assets User";
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objassets.EntryParameter = ep;
            return objassets;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
                MessageBox.Show("Empty field");
            }
            else
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    AssetsUser objAssets = this.PopulatedAssetsuser();
                    for (int i=0;i<lvwAssetsUser.Items.Count;i++)
                    {
                        short k = atms.SaveAssetsUser(cboDepartment.SelectedValue.ToString(), lvwAssetsUser.Items[i].Text,
                                                        Convert.ToInt32(lvwAssetsUser.Items[i].SubItems[1].Text), objAssets.formName, objAssets);
                    }
                    //btnNew.PerformClick();
                    txtStartingNo.Text = "";
                    txtTotalNoUser.Text = "";
                    lvwAssetsUser.Items.Clear();
                    lvwDasboard.Items.Clear();
                }
            }
        }
        private void GetLastNo(string strDepid)
        {
            List<AssetsUser> oAsset = atms.GetLastNo("LastNo",strDepid).ToList();
            foreach(AssetsUser objAs in oAsset)
            {
                txtStartingNo.Text = objAs.LaetNo;
            }

        }
        private void DisplayUserStatus(string strDepid)
        {
            List<AssetsUser> objUser = atms.GetAssetsUserStatus("AssetsUserStatus", strDepid).ToList();
            foreach(AssetsUser user in objUser)
            {
                ListViewItem item = new ListViewItem();
                if (user.intStatus ==0)
                {
                    item.Text = user.UserName + "-" + user.UserId;
                    item.ImageIndex = 2;
                    this.lvwDasboard.Items.Add(item);
                }
                if (user.intStatus == 1)
                {
                    item.Text = user.UserName + "-" + user.UserId;
                    item.ImageIndex = 1;
                    this.lvwDasboard.Items.Add(item);
                }

            }
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwDasboard.Items.Clear();
            lvwAssetsUser.Items.Clear();
            if (cboDepartment.SelectedIndex >= 0 || cboDepartment.SelectedIndex == -1)
            {
                if (cboDepartment.Text != "Select")
                {
                    GetLastNo(cboDepartment.SelectedValue.ToString());
                    DisplayUserStatus(cboDepartment.SelectedValue.ToString());
                }
            }
        }

        private void cboDepartment_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) ||
                    (e.KeyCode == Keys.Left) ||
                    (e.KeyCode == Keys.Right) ||
                    (e.KeyCode == Keys.Up) ||
                    (e.KeyCode == Keys.Down) ||
                    (e.KeyCode == Keys.Delete) ||
                    (e.KeyCode == Keys.PageUp) ||
                    (e.KeyCode == Keys.PageDown) ||
                    (e.KeyCode == Keys.Home) ||
                    (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboDepartment.Text;

            // Find the first match for the typed value.
            index = this.cboDepartment.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboDepartment.Items[index].ToString();

                // Select this item from the list.
                this.cboDepartment.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboDepartment.SelectionStart = actual.Length;
                this.cboDepartment.SelectionLength = found.Length;
            }
        }

        private void lvwDasboard_MouseDown(object sender, MouseEventArgs e)
        {
            //frmAssetsDetails frm = new frmAssetsDetails();
            //frm.ShowDialog();
        }

        private void lvwDasboard_Click(object sender, EventArgs e)
        {

        }

        private void lvwDasboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDasboard.SelectedItems.Count > 0)
            {
                frmAssetsDetails frm = new frmAssetsDetails(cboDepartment.SelectedValue.ToString(), lvwDasboard.SelectedItems[0].Text.ToString(), cboDepartment.Text.ToString());
                //frm.strDep = cboDepartment.SelectedValue.ToString();
                //frm.strUser = lvwDasboard.SelectedItems.ToString();
                frm.ShowDialog();
            }
        }
    }
}
