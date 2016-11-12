using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.ACMSSR;
using AH.DUtility;
using System.Security.Cryptography;
using System.IO;
using System.Web;

namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmFormatPassword : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmFormatPassword()
        {
            InitializeComponent();
        }
        EntryParameter oEntryParameter = new EntryParameter();
        User oUserBO = new User();

        private void frmPasswordReset_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Select();         
            txtUserName.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmployeeID"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
          
            try
            {

                oUserBO = this.PopulateObject();
                short i = clnt.UpdateUserPassword(oUserBO);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    
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
        //public string Encrypt(string toEncrypt)
        //{
        //    bool useHashing = true;
        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
        //    string key = txtEmployeeID.Text;

        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            
        //        hashmd5.Clear();
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(key);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    //set the secret key for the tripleDES algorithm
        //    tdes.Key = keyArray;
        //    //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)
        //    tdes.Mode = CipherMode.ECB;
        //    //padding mode(if any extra byte added)
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    //transform the specified region of bytes array to resultArray
        //    byte[] resultArray = cTransform.TransformFinalBlock
        //            (toEncryptArray, 0, toEncryptArray.Length);
        //    //Release resources held by TripleDes Encryptor
        //    tdes.Clear();
        //    //Return the encrypted data into unreadable string format
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);

          
        //}


        private User PopulateObject()
        {
            User OUser = new User();

            OUser.EmpID = txtEmployeeID.Text;
            OUser.UserPassw =Utility.Encrypt("123",txtEmployeeID.Text);
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            OUser.EntryParameter = oEntryParameter;
            return OUser;
        }
      

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Enabled = true;      
            txtUserName.Enabled = false;
            txtUserName.BackColor = Color.Silver;      
            txtEmployeeID.Select();
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Length == 4)
            {
                User oUser = clnt.GetUser(txtEmployeeID.Text);
                if (txtEmployeeID.Text != oUser.EmpID)
                {
                    MessageBox.Show("Please put a valid user id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmployeeID.Focus();
                    return;
                }
                txtUserName.Text = oUser.NickName;
                txtDepartment.Text = oUser.Department.DepartmentTitle;

            }
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
