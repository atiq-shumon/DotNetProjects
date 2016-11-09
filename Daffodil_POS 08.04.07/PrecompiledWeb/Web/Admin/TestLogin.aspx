<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_TestLogin, App_Web_tb9ntuv2" title="Login Test Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">



<div id="masterDiv" class="DPOSStyleSheet.css" >
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
                    &nbsp;</td>
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


					  <table width="60%" border="0" align="center" style="background-color:White; border-right: silver thick solid; border-top: silver thick solid; border-left: silver thick solid; border-bottom: silver thick solid;">
                           <tr> 
                            <td colspan="3" style="border-bottom: red thin solid; height:50px; font-size:10pt; font-family:Verdana; vertical-align:bottom;">Login Details</td>
                            
                          </tr>
					  
                          <tr> 
                            
                            <td width="30%" style="font-size:10pt; font-family:Verdana;">User Name</td>
                            <td width="25%">
                                <asp:TextBox id="txtUserName" runat="server">
                                </asp:TextBox></td>
                            <td width="5%">&nbsp;<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                    Display="Dynamic" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                          </tr>

                          <tr> 
                            
                            <td style="font-size:10pt; font-family:Verdana;">Password</td>
                            <td>
                                <asp:TextBox id="txtPassword" runat="server" TextMode="Password"
                                    Width="149px"></asp:TextBox></td>
                            <td>&nbsp;</td>
                          </tr>
                          <tr>
                              <td style="font-size: 10pt; font-family: Verdana">
                                  &nbsp;</td>
                              <td><asp:Button id="Button1" runat="server" BackColor="Gainsboro" Font-Names="Verdana"
                                      Text="Login" OnClick="Button1_Click" CommandName="Login" /></td>
                              <td>
                                  &nbsp;</td>
                          </tr>
                          <tr> 
                            <td colspan="3" style="border-top: red thin solid; height:50px;">&nbsp;
                                <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName"
                                    Display="Dynamic" ErrorMessage="* Please! Enter your user name." SetFocusOnError="True">
                                </asp:RequiredFieldValidator>
                                <asp:ValidationSummary id="ValidationSummary1" runat="server" DisplayMode="SingleParagraph"
                                    ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary></td>
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





</asp:Content>

