<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default_aspx" MasterPageFile="~/MasterPage.master" Title ="::... Home Page ...::"%>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


    <div>
        <p class="MsoNormal" style="margin: 0in 0in 0pt">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; border-collapse: collapse;
                height: 128px;" x:str="">
                <colgroup>
                    <col style="width: 226pt; mso-width-source: userset; mso-width-alt: 11008" width="301" />
                    <col style="width: 48pt" width="64" />
                </colgroup>
                <tr height="41" style="height: 30.75pt">
                    <td class="xl22" style="border-left-color: #e0dfe3; border-bottom-color: #e0dfe3;
                        border-top-color: #e0dfe3; height: 81pt; background-color: transparent; border-right-color: #e0dfe3; vertical-align: middle; text-align: center;"
                        width="80%">
                        <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl="~/Images/DSL/DSL.JPG"
                            Width="744px" /></td>
                </tr>
                <tr height="26" style="font-size: 24pt; height: 19.5pt">
                    <td class="xl23" style="border-left-color: #e0dfe3; border-bottom-color: #e0dfe3;
                        vertical-align: top; border-top-color: #e0dfe3; background-color: transparent;
                        text-align: center; border-right-color: #e0dfe3; height: 41pt;" width="80%">
                        <span style="color: #ffffff; background-color: #33ccff"><strong style="vertical-align: middle;
                            text-align: justify">::..Welcome To Daffodil Point Of Sales..::<br />
                            <br />
                            <asp:Label ID="Label1" runat="server" BackColor="White" ForeColor="Black" Text="Computer Name"></asp:Label><br />
                            <asp:TextBox ID="txtComputerName" runat="server" BorderColor="White" BorderStyle="None" style="vertical-align: middle; text-align: center" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue"></asp:TextBox><br />
                            <asp:Label ID="Label2" runat="server" BackColor="White" ForeColor="Black" Text="IP Address"></asp:Label><br />
                            <asp:TextBox ID="txtIPAddress" runat="server" BorderColor="White" BorderStyle="None" style="font-weight: bold; vertical-align: middle; text-align: center" Font-Size="X-Large" ForeColor="Blue"></asp:TextBox><br />
                            <br />
                            <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="RedirectToLoginPage" />
                            <br />
                        </strong></span></td>
                </tr>
            </table>
        </p>
    
    </div>
    </asp:Content>
    <%--</form>
</body>
</html>--%>
