<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_Setup_Branch_Default, App_Web_gpsu6vxa" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css" style="text-align: center" >
    <span>
        <br />
        <strong><span style="background-color: #ccffff">
        ::..This
        page is now underconstruction..::<br />
        </span>
        <br />
        </strong>
        <span style="background-color: #ffccff"><span style="text-decoration: underline"><strong>
                    All Branch pages link<br />
            <br />
        </strong></span>
        </span>
        <table style="font-weight: bold;">
            <tr>
                <td style="width: 10%; text-align: center">
                    <span style="font-size: 12pt"></span>
                </td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink11" runat="server" Font-Size="12pt" NavigateUrl="~/Admin/Setup/Default.aspx" ForeColor="Fuchsia">Go to Setup Home</asp:HyperLink>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                </td>
                <td style="width: 50%; text-align: left;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    1.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="~/Admin/Setup/Branch/BranchTypeInfo.aspx">Branch Type Information</asp:HyperLink></td>
                <td style="width: 50%; text-align: left">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center;">
                    2.</td>
                <td style="width: 40%; text-align: left;">
                    <asp:HyperLink id="HyperLink2" runat="server" NavigateUrl="~/Admin/Setup/Branch/BranchInfo.aspx">Branch Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
        </table>
        <br />
    </span>
    </div>
</asp:Content>

