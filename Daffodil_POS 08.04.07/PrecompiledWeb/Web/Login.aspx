<%@ page language="C#" autoeventwireup="true" inherits="Login_aspx, App_Web_pgrxecpj" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top">&nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top">
    <table width="100%">
        <tr>
          <td style="width: 5%">&nbsp;</td>
          <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" style="height:100px;">
                    </td>
              </tr>
              <tr> 
                <td align="left" valign="top">
                <table width="100%" border="0" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-collapse: collapse; border-bottom-style: solid" >
                    <tr>
                      <td style="text-align: center; font-weight: bold; font-size: 20pt; font-family: Verdana; height: 70px; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                      <script language="javascript">

/*
RAINBOW TEXT Script by Matt Hedgecoe (c) 2002
Featured on JavaScript Kit
For this script, visit http://www.javascriptkit.com
*/

// ********** MAKE YOUR CHANGES HERE

var text="Daffodil Point Of Sales" // YOUR TEXT
var speed=80 // SPEED OF FADE

// ********** LEAVE THE NEXT BIT ALONE!


if (document.all||document.getElementById){
document.write('<span id="highlight">' + text + '</span>')
var storetext=document.getElementById? document.getElementById("highlight") : document.all.highlight
}
else
document.write(text)
var hex=new Array("00","14","28","3C","50","64","78","8C","A0","B4","C8","DC","F0")
var r=1
var g=1
var b=1
var seq=1
function changetext(){
rainbow="#"+hex[r]+hex[g]+hex[b]
storetext.style.color=rainbow
}
function change(){
if (seq==6){
b--
if (b==0)
seq=1
}
if (seq==5){
r++
if (r==12)
seq=6
}
if (seq==4){
g--
if (g==0)
seq=5
}
if (seq==3){
b++
if (b==12)
seq=4
}
if (seq==2){
r--
if (r==0)
seq=3
}
if (seq==1){
g++
if (g==12)
seq=2
}
changetext()
}
function starteffect(){
if (document.all||document.getElementById)
flash=setInterval("change()",speed)
}
starteffect()
</script>

              </td>
                    </tr>
                    <tr>
                      <td style="height: 200px; background-color: #c8eaea; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">


					  <table width="40%" border="0" align="center" style="background-color:White; border-right: silver thick solid; border-top: silver thick solid; border-left: silver thick solid; border-bottom: silver thick solid;">
                          <tr> 
                            <td colspan="2" style="border-top: red thin solid; height:50px;">
                                <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4"
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
                                    ForeColor="#333333" Height="143px" OnAuthenticate="Login1_Authenticate" Width="326px">
                                    <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                                    <TextBoxStyle Font-Size="0.8em" />
                                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px"
                                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                                    <LayoutTemplate>
                                        <table border="0" cellpadding="4" cellspacing="0" style="border-collapse: collapse">
                                            <tr>
                                                <td>
                                                    <table border="0" cellpadding="0" style="width: 326px; height: 143px">
                                                        <tr>
                                                            <td align="center" colspan="2" style="font-weight: bold; font-size: 0.9em; color: white;
                                                                background-color: #507cd1">
                                                                Log In</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label></td>
                                                            <td>
                                                                <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                                    ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label></td>
                                                            <td>
                                                                <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" Width="103px"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                                    ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center" colspan="2" style="color: red">
                                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" colspan="2">
                                                                <asp:Button ID="LoginButton" runat="server" BackColor="White" BorderColor="#507CD1"
                                                                    BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="Verdana"
                                                                    Font-Size="0.8em" ForeColor="#284E98" OnClick="LoginButton_Click" Text="Log In"
                                                                    ValidationGroup="Login1" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </LayoutTemplate>
                                </asp:Login>
                            </td>
                          </tr>
                          
                        </table> 


                    
                    </td>
                    </tr>
                    <tr>
                      <td  style="height: 50px; background-color: #29b3f2; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;" ></td>
                    </tr>
                  </table></td>
              </tr>

              
              <tr> 
                <td align="left" valign="top">
                    </td>
              </tr>
            </table></td>
          <td style="width:5%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top" style="height: 17px"></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
