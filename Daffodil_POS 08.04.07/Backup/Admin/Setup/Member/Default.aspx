<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Setup_Member_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css" style="text-align: center" >
    <span>
        <strong><span style="background-color: #ccffff">
            <br />
        ::..This
        page is now underconstruction..::<br />
        </span>
        <br />
        </strong>
        <span style="background-color: #ffccff"><span style="text-decoration: underline"><strong>
                    All Member pages link<br />
            <br />
        </strong></span>
        </span>
        <table style="font-weight: bold;">
            <tr>
                <td style="width: 10%; text-align: center">
                    <span style="font-size: 12pt"></span>
                </td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink11" runat="server" Font-Size="12pt" NavigateUrl="~/Admin/Default.aspx" ForeColor="Fuchsia">Go to Setup Home</asp:HyperLink>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;
                </td>
                <td style="width: 50%; text-align: left;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    1.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink9" runat="server" NavigateUrl="~/Admin/Setup/Member/MemberInfo.aspx">Member Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
        </table>
        <br />
    </span>
    </div>
</asp:Content>

