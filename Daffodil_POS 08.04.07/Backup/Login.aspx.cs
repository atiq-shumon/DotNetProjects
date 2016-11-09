using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Login_aspx : Page
{
    //protected void Page_Load(object sender, EventArgs e)
    //{

    //}
    //protected void LoginButton_Click(object sender, EventArgs e)
    //{

    //}
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (Membership.ValidateUser(Login1.UserName, Login1.Password))
        {
            
            FormsAuthentication.SetAuthCookie(Login1.UserName, Login1.RememberMeSet);
            Response.Redirect(FormsAuthentication.GetRedirectUrl(Login1.UserName, Login1.RememberMeSet));
            

            //    FormsAuthentication.SetAuthCookie(Login1.UserName, Login1.RememberMeSet);
            //    Response.Redirect(FormsAuthentication.GetRedirectUrl(Login1.UserName, Login1.RememberMeSet));
        }
        //if (User.Identity.Name.ToLower() == "admin")
        //{
        ////    Response.Redirect("~/Admin/Setup/Default.aspx");
        //}
        ////else
        ////    Response.Redirect("~/Admin/Setup/Booth/BoothRegistration.aspx");
    }

    protected void ForgotPasswordButton_Click(object sender, EventArgs e)
    {
        this.PasswordRecovery.Visible = true;
    }
    protected void PasswordRecovery_Init(object sender, EventArgs e)
    {
        //SiteSettings s = SiteSettings.GetSharedSettings();
        //PasswordRecovery.MailDefinition.From = s.SiteEmailFromField;
    }
    protected void PasswordRecovery_SendMailError(object sender, SendMailErrorEventArgs e)
    {
        //System.Text.StringBuilder mailLink = new System.Text.StringBuilder("<a href=\"mailto:");
        //try
        //{
        //    mailLink.Append(SiteSettings.GetSharedSettings().SiteEmailAddress);
        //}
        //catch
        //{
        //    mailLink.Append("#");
        //}
        //mailLink.Append("\">system administrator</a>");
        //PasswordRecovery.SuccessText = "A problem occurred sending the email. " +
        //    "Please contact the " + mailLink.ToString() + ".";
        //e.Handled = true;
    }
}
