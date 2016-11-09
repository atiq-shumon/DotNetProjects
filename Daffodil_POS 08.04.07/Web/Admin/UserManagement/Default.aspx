<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_UserManagement_Default" Title="User Management Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="masterDiv" class="DPOSStyleSheet.css" style="text-align: center" >
  
       
        <span style="background-color: #ffccff"><span style="text-decoration: underline"><strong>
            <br />
            <br />
            <br />
            <br />
            &nbsp;Page link<br />
            <br />
        </strong></span>
        </span>
        <table style="font-weight: bold; width: 608px;">
            <tr>
                <td style="width: 10%; text-align: center">
                    <span style="font-size: 12pt"></span>
                </td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink11" runat="server" Font-Size="12pt" NavigateUrl="~/Default.aspx" ForeColor="Fuchsia">Go to Home Page</asp:HyperLink></td>
                <td style="width: 50%; text-align: left;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    1.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="~/Admin/Setup/Default.aspx">All Setup Pages Link</asp:HyperLink></td>
                <td style="width: 50%; text-align: left">
                </td>
            </tr>
        </table>
        <br />
   
    </div>
</asp:Content>

