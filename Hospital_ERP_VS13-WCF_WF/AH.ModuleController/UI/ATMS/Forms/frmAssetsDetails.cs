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
    public partial class frmAssetsDetails : AH.Shared.UI.frmSmartFormStandard
    {
        public string strDepCode { set; get; }
        public string strUser { set; get; }
        public string strDepName { set; get; }
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmAssetsDetails(string Depcode,string User,string DepName)
        {
             strDepCode = Depcode;
             strUser=User;
             strDepName = DepName;
             InitializeComponent();

        }
        private void GetDetails()
        {
            int j=0;
            strUser = strUser.Substring(strUser.LastIndexOf("-") + 1);
            List<AssetsIssue> objadd = atms.GetAssetsUserInfo("", strDepCode, strUser).ToList();
            foreach (AssetsIssue add in objadd)
            {
                DG.Rows[j].Cells[0].Value = add.IssueNo;
                DG.Rows[j].Cells[1].Value = add.Issudate;
                DG.Rows[j].Cells[2].Value = add.ProductName;
                DG.Rows[j].Cells[3].Value = add.brandName;
                DG.Rows[j].Cells[4].Value = add.ModelName;
                DG.Rows[j].Cells[5].Value = add.UnitName;
                DG.Rows[j].Cells[6].Value = add.dblQty;
                j = j + 1;
            }

        }
        private void frmAssetsDetails_Load(object sender, EventArgs e)
        {
            txtDepID.Text = strDepName;
            txtUser.Text = strUser;
            GetDetails();
        }
        private bool validationfields()
        {
            //if (txtTagNo.Text.ToString() == "")
            //{
            //    txtTagNo.Focus();
            //    return true;
            //}
            //if (txtProductCode.Text.ToString() == "")
            //{
            //    txtProductCode.Focus();
            //    return true;
            //}
           

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
                return;
            }
            else
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    //AssetsIssue objIssue = this.PopulateVoucherUpdate();
                    //int strIssueNo = atms.UpdatevoucherMaster(objIssue);
                    //if (strIssueNo == 1)
                    //{
                    //    short i = atms.UpdatevoucherTran(objIssue);
                    //    this.Dispose();
                    //}



                }
            }
        }
       
    }
}
