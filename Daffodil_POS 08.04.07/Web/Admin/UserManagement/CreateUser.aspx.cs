using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_UserManagement_CreateUser : Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["adminrolename"]))
            {
                Response.Redirect("~/customerrorpages/NotAuthorized.aspx");
            }
        }
        
    }
    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("~/default.aspx");
    }
    protected void CreateUserWizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if (CreateUserWizard1.ActiveStep.ID == "WizardStep1")
        {
            TextBox t = ((TextBox)CreateUserWizard1.ActiveStep.FindControl("TextBox1"));
            ViewState["firstname"] = t.Text;
            t = ((TextBox)CreateUserWizard1.ActiveStep.FindControl("TextBox2"));
            ViewState["lastname"] = t.Text;
        }

        if (CreateUserWizard1.ActiveStep.ID == "WizardStep2")
        {
            MembershipUser objUser = Membership.GetUser();
            DropDownList ddl = ((DropDownList)CreateUserWizard1.ActiveStep.FindControl("DropDownList1"));
            if (ddl != null)
            {
                Roles.AddUserToRole(objUser.UserName, ddl.SelectedValue);
            }
            Profile.UserName = objUser.UserName;
            Profile.Email = objUser.Email;
            Profile.FirstName = ViewState["firstname"].ToString();
            Profile.LastName = ViewState["lastname"].ToString();
            Profile.GeneralUser.ResumeID = -1;
            Profile.PowerUser.CompanyID = -1;
        }
    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {

    }
    protected void CreateUserWizard1_ActiveStepChanged(object sender, EventArgs e)
    {
        if (CreateUserWizard1.ActiveStep.ID == "WizardStep2")
        {
            DropDownList ddl = ((DropDownList)CreateUserWizard1.ActiveStep.FindControl("DropDownList1"));
            if (ddl != null)
            {
                ListItem li1 = new ListItem("General User", ConfigurationManager.AppSettings["generaluserrolename"]);
                ListItem li2 = new ListItem("Power User", ConfigurationManager.AppSettings["poweruserrolename"]);
                ListItem li3 = new ListItem("Purchase User", ConfigurationManager.AppSettings["purchaseuserrolename"]);
                ListItem li4 = new ListItem("Sales User", ConfigurationManager.AppSettings["salesuserrolename"]);
                ddl.Items.Add(li1);
                ddl.Items.Add(li2);
                ddl.Items.Add(li3);
                ddl.Items.Add(li4);

            }

        }
    }
}
