using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmGroup : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public string strMode { set; get; }
        public string strindex { set; get; }

        public frmGroup()
        {
            InitializeComponent();
        }
        private bool validationfields()
        {
            if (txtGroupName.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private AssetsGroup PopulateGroup()
        {
            AssetsGroup Groups = new AssetsGroup();
            if (txtGroupID.Text != "")
            {
                Groups.GroupID = txtGroupID.Text;
            }
            Groups.GroupName = txtGroupName.Text;
            Groups.FormName = "Groups";
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            Groups.EntryParameter = ep;
            return Groups;
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
                    AssetsGroup objGrp = this.PopulateGroup();
                    short i = atms.SaveGroup(objGrp);
                    btnNew.PerformClick();
                    txtGroupName.Focus();
                }
            }
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
