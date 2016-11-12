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
    public partial class frmPasswordReset : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmPasswordReset()
        {
            InitializeComponent();
        }
        EntryParameter oEntryParameter = new EntryParameter();
        User oUserBO = new User();

        private void frmPasswordReset_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Select();
            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtUserName.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmployeeID", "txtOldPassword","txtNewPassword","txtConfirmPassword" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {               
                MessageBox.Show("Confirm password are not match, Please check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
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


        private User PopulateObject()
        {
            User OUser = new User();
            OUser.EmpID = txtEmployeeID.Text;
            OUser.UserPassw = Utility.Encrypt(txtNewPassword.Text,txtEmployeeID.Text);
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            OUser.EntryParameter = oEntryParameter;
            return OUser;
        }


        //public string Encrypt(string toEncrypt,srting UserID)
        //{
        //    bool useHashing = true;
        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        //  //  string key = txtEmployeeID.Text;
        
        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
        //        //Always release the resources and flush data
        //        //of the Cryptographic service provide. Best Practice

        //        hashmd5.Clear();
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(UserID);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    //set the secret key for the tripleDES algorithm
        //    tdes.Key = keyArray;
        //    //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    //transform the specified region of bytes array to resultArray
        //    byte[] resultArray = cTransform.TransformFinalBlock
        //            (toEncryptArray, 0, toEncryptArray.Length);     
        //    tdes.Clear();         
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);

          
        //}

        //public string Decrypt(string cipherString, string UserID)
        //{
        //    bool useHashing = true;
        //    byte[] keyArray;

        //    byte[] toEncryptArray = Convert.FromBase64String(cipherString);

        //    //string key = txtEmployeeID.Text;

        //    if (useHashing)
        //    {
        //        //if hashing was used get the hash code with regards to your key
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
        //        //release any resource held by the MD5CryptoServiceProvider

        //        hashmd5.Clear();
        //    }
        //    else
        //    {
        //        //if hashing was not implemented get the byte code of the key
        //        keyArray = UTF8Encoding.UTF8.GetBytes(UserID);
        //    }

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    //set the secret key for the tripleDES algorithm
        //    tdes.Key = keyArray;
        //    //mode of operation. there are other 4 modes.
        //    //We choose ECB(Electronic code Book)

        //    tdes.Mode = CipherMode.ECB;
        //    //padding mode(if any extra byte added)
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateDecryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock
        //            (toEncryptArray, 0, toEncryptArray.Length);
        //    //Release resources held by TripleDes Encryptor
        //    tdes.Clear();
        //    //return the Clear decrypted TEXT
        //    return UTF8Encoding.UTF8.GetString(resultArray);


        //}

        /************************************************************************/
 
        private void btnCheck_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmployeeID", "txtOldPassword"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            User oUser = clnt.GetUser(txtEmployeeID.Text);
           
            if (txtEmployeeID.Text != oUser.EmpID)
            {              
                MessageBox.Show("Please put a valid user id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeID.Focus();
                return;
            }
        
            txtUserName.Text = oUser.NickName;

            string decryptpass = Utility.Decrypt(oUser.UserPassw,txtEmployeeID.Text);//Utility.Decrypt(oUser.UserPassw);
            if (txtOldPassword.Text != decryptpass)
            {              
                MessageBox.Show("You enter a wrong password, Please check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Focus();
                return;
            }
            if (txtEmployeeID.Text == oUser.EmpID && txtOldPassword.Text == decryptpass)
            {
                txtEmployeeID.Enabled = false;
                txtOldPassword.Enabled = false;
                txtUserName.Enabled = false;
                txtNewPassword.Enabled=true;
                txtConfirmPassword.Enabled=true;
                txtNewPassword.Select();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Enabled = true;
            txtOldPassword.Enabled = true;
            txtUserName.Enabled = false;
            txtUserName.BackColor = Color.Silver;
            txtNewPassword.Enabled = false;
            txtNewPassword.BackColor = Color.Silver;
            txtConfirmPassword.Enabled = false;
            txtConfirmPassword.BackColor = Color.Silver;
            txtEmployeeID.Select();
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
          
        }
      
    }
}
