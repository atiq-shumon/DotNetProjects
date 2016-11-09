using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;

public partial class Default_aspx : System.Web.UI.Page 
{
    public Default_aspx()
    {
        Load += new EventHandler(Page_Load);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        String strHostName = Dns.GetHostName();

        //this.TextBox1.Text = Request.UserHostAddress;
        this.txtIPAddress.Text = GetIP().ToString();
        this.txtComputerName.Text = strHostName.ToUpper();
    }
  private  String GetIP()
    {

        String strHostName = Dns.GetHostName();

        // Find host by name
        IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

        // Grab the first IP addresses
        String   IPStr = "";
        foreach (IPAddress ipaddress in iphostentry.AddressList)
        {
            IPStr = ipaddress.ToString();
            return IPStr;
        }
        return IPStr;
    }
}
