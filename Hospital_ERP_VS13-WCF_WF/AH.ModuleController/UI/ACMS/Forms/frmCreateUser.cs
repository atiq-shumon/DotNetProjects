using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AH.ModuleController.AccountsMSSR;
using AH.ModuleController.ACMSSR;
using AH.DUtility;
using System.Security.Cryptography;

//using AH.Shared.MODEL;


namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmCreateUser : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmCreateUser()
        {
            InitializeComponent();
        }
        public string ReturnValueid { get; set; }
        public string ReturnValuestring { get; set; }
        
        User oUserBO = new User();
        EntryParameter oEntryParameter = new EntryParameter();
        private void FormatGrid()
        {
            lvUser.Columns.Add("Emp ID",120, HorizontalAlignment.Center);
            lvUser.Columns.Add("Name", 250, HorizontalAlignment.Center);
            lvUser.Columns.Add("Email", 250, HorizontalAlignment.Center);
            lvUser.Columns.Add("Update Date", 150, HorizontalAlignment.Center);
            lvUser.Columns.Add("Valid Upto", 150, HorizontalAlignment.Center);
            lvUser.Columns.Add("Remarks", 200, HorizontalAlignment.Center);
            lvUser.Columns.Add("Question Title", 200, HorizontalAlignment.Left);
            lvUser.Columns.Add("Answer",200, HorizontalAlignment.Left);
            lvUser.Columns.Add("userPass", 0, HorizontalAlignment.Left);
            lvUser.Columns.Add("Pincode", 0, HorizontalAlignment.Left);
            lvUser.Columns.Add("Is Active", 100, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvUser.Items.Clear();
            List<User> oUserBOs = new List<User>();
            oUserBOs = clnt.GetsUser().ToList();
            foreach (User fcat in oUserBOs)
            {
                ListViewItem itm = new ListViewItem(fcat.EmpID);
                itm.SubItems.Add(fcat.NickName);
                itm.SubItems.Add(fcat.Email);
                itm.SubItems.Add(fcat.EntryParameter.EntryDate.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(fcat.ValidUpto);
                itm.SubItems.Add(fcat.Remarks);
                itm.SubItems.Add(fcat.SecurityQuestion.QTitle);
                itm.SubItems.Add(fcat.SecurityQuestion.Answer);
                itm.SubItems.Add(fcat.UserPassw);
                itm.SubItems.Add(fcat.PinCode);
                itm.SubItems.Add(fcat.EntryParameter.Active);
                lvUser.Items.Add(itm);
            }
            this.lvUser.View = View.Details;
        }
        private void LoadUserGroupCombo()
        {
            List<UserGroup> oUserGroupBOs = new List<UserGroup>();
            oUserGroupBOs = clnt.GetsUserGroupCbo().ToList();
            //cboUserGroup.DataSource = oUserGroupBOs;
            //cboUserGroup.DisplayMember = "GroupTitle";
            //cboUserGroup.ValueMember = "GroupID";
        }
        private void LoadUserSecQuestionCombo()
        {
            List<SecurityQuestion> oSecurityQuestionBOs = new List<SecurityQuestion>();
            oSecurityQuestionBOs = clnt.GetsSecurityQuestionCbo().ToList();
            cboSecQuestion.DataSource = oSecurityQuestionBOs;
            cboSecQuestion.DisplayMember = "QTitle";
            cboSecQuestion.ValueMember = "QID";
        }
        private User PopulateObject()
        {
            UserGroup oUserGroup = new UserGroup();
            oUserBO.UserGroup = oUserGroup;
            SecurityQuestion oSecurityQuestion = new SecurityQuestion();
            oUserBO.SecurityQuestion = oSecurityQuestion;
            oUserBO.EmpID = txtUID.Text;
            oUserBO.UserGroup.GroupID = "1";
            oUserBO.ValidUpto = dtValidupto.Value.ToString("dd-MM-yyyy");
            oUserBO.UserPassw = Utility.Encrypt(txtPassword.Text, txtUID.Text);//txtPassword.Text;
            oUserBO.PinCode = txtPinCode.Text;//CalculateMD5Hash(txtPinCode.Text); 
            oUserBO.Email = txtEmail.Text;
            oUserBO.SecurityQuestion.QID = cboSecQuestion.SelectedValue.ToString();
            oUserBO.SecurityQuestion.Answer = txtAnswer.Text;
            oUserBO.Remarks = txtRemarks.Text;
            oUserBO.NickName = txtUserName.Text;


            Module oModule = new Module();
            oModule.ModuleID = "ADMIS";
            oUserBO.Module = oModule;

            if (chckActive.Checked == true)
            {
                oEntryParameter.Active = "1";
            }
            else
            {
                oEntryParameter.Active = "0";
            }
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            oUserBO.EntryParameter = oEntryParameter;
            return oUserBO;
        }

        private bool SavePreRequisit()
        {
            List<string> vf = new List<string>() { "txtUID", "cboUserGroup", "txtPassword", "txtPinCode", "cboSecQuestion", "txtAnswer" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }

        private bool EditDelPreRequisit()
        {
            List<string> vf = new List<string>() { "txtUID", "cboUserGroup", "txtPassword", "txtPinCode", "cboSecQuestion", "txtAnswer" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            txtUID.Select();
            chckActive.Checked = true;
            //lblInfo.Enabled = false;
            FormatGrid();
            LoadListView();
            LoadUserGroupCombo();
            LoadUserSecQuestionCombo();
         
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utility.IsDuplicateFoundInList(lvUser, 0, txtUID.Text))
            { 
                MessageBox.Show("Person is already in the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUID.Focus();
                return;
            }

            btnEdit.Enabled = false;
            if (txtEmail.Text != null)
            {
                IsValidEmailAddress(txtEmail.Text);
            }
            if (!SavePreRequisit())
            {
                return;
            }
            if (SavePreRequisit())
            {
                try
                {
                    AH.ModuleController.ACMSSR.EmployeeMaster oEmpMas = clnt.GetEmpoyee(txtUID.Text);
                    if (chckActive.Checked==false)
                    {
                        MessageBox.Show("You need to change it's active status", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chckActive.Focus();
                        return;
                    }
                   
                        if (txtUID.Text == oEmpMas.EmpId)
                        {
                            oUserBO = clnt.SaveUser(PopulateObject());
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Please put a valid employee id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUID.Select();
                            return;
                        }

                        //  oUserBO = clnt.SaveUser(PopulateObject());
                        if (oUserBO.EntryParameter.ErrorMessage == "")
                        {
                            LoadListView();
                            LoadUserGroupCombo();
                            LoadUserSecQuestionCombo();
                            btnNew.PerformClick();
                            txtUID.Enabled = true;
                            txtPassword.Enabled = true;
                            txtPinCode.Enabled = true;
                            cboSecQuestion.Enabled = true;
                            txtAnswer.Enabled = true;
                            dtValidupto.Enabled = true;
                            txtRemarks.Enabled = true;
                            return;
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

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (lvUser.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvUser.SelectedItems[0];
                txtUID.Text = itm.SubItems[0].Text; //Emp ID 
                txtUserName.Text = itm.SubItems[1].Text; //Name
                txtEmail.Text = itm.SubItems[2].Text; //Email
                dtValidupto.Text = itm.SubItems[4].Text; //Valid Till
                txtRemarks.Text = itm.SubItems[5].Text; //Remarks
                cboSecQuestion.Text = itm.SubItems[6].Text; //Question Title
                txtAnswer.Text = itm.SubItems[7].Text; //Answer
                txtPassword.Text = itm.SubItems[8].Text; //Password
                txtPinCode.Text = itm.SubItems[9].Text; //PinCode
                if (itm.SubItems[10].Text.ToString() == "1")
                {
                    chckActive.Checked = true;
                }
                if (itm.SubItems[10].Text.ToString() == "0")
                {
                    chckActive.Checked = false;
                }
            }
            txtPassword.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!SavePreRequisit())
            {
                return;
            }
            if (SavePreRequisit())
            {
                try
                {
                    oUserBO = clnt.DeleteUser(txtUID.Text.ToString());
                    if (oUserBO.EntryParameter.ErrorMessage == "")
                    {
                        LoadListView();
                        LoadUserGroupCombo();
                        LoadUserSecQuestionCombo();
                        btnNew.PerformClick();
                        
                        return;
                    }
                    if (oUserBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oUserBO.EntryParameter.ErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!SavePreRequisit())
            {
                return;
            }
            if (SavePreRequisit())
            {
                try
                {
                    oUserBO = clnt.EditUser(PopulateObject()); 
                    if (oUserBO.EntryParameter.ErrorMessage == "")
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        LoadUserGroupCombo();
                        LoadUserSecQuestionCombo();
                        btnNew.PerformClick();                      
                        return;
                    }
                    if (oUserBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oUserBO.EntryParameter.ErrorMessage);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
       

        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUID.Enabled = true;
            txtPassword.Enabled = true;
           // txtPinCode.Enabled = true;
            cboSecQuestion.Enabled = true;
            txtAnswer.Enabled = true;
            dtValidupto.Enabled = true;
            txtRemarks.Enabled = true;
            txtPassword.Text = "123";
            txtPinCode.Text = "123";
            txtPassword.Enabled  = true;

            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }


        private void txtUID_Leave(object sender, EventArgs e)
        {

            lblInfo.Text = "";

            if (txtUID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtUID.Text != string.Empty)
            {
                AH.ModuleController.ACMSSR.EmployeeMaster oEmpMas = clnt.GetEmpoyee(txtUID.Text);

                if (txtUID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    txtUserName.Text = oEmpMas.FirstName;
                    txtEmail.Text = oEmpMas.Email;
                }
                else
                {
                    MessageBox.Show("Please put a valid user id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   // txtUID.Select();
                    return;
                }

            }
        }

        private void txtUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUID_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

     }

}
