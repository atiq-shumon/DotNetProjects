<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_Setup_Default, App_Web_cz-kbp-8" title="Setup Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css" style="text-align: center" >
  
       
        <span style="background-color: #ffccff"><span style="text-decoration: underline"><strong>
            <br />
            <br />
                    All Setup pages link<br />
            <br />
        </strong></span>
        </span>
        <table style="font-weight: bold;">
            <tr>
                <td style="width: 10%; text-align: center">
                    <span style="font-size: 12pt"></span>
                </td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink11" runat="server" Font-Size="12pt" NavigateUrl="~/Admin/Login.aspx" ForeColor="Fuchsia">Go to Home Page</asp:HyperLink></td>
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
            <tr>
                <td style="width: 10%; text-align: center">
                    3.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink3" runat="server" NavigateUrl="~/Admin/Setup/Booth/BoothInfo.aspx">Booth Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    4.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink4" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductCategoryInfo.aspx">Product Category  Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    5.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink5" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductSubCategoryInfo.aspx">Product Sub Category  Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    6.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink6" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductUnitInfo.aspx">Product Unit Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    7.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink7" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductInfo.aspx">Product Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    8.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink8" runat="server" NavigateUrl="~/Admin/Setup/Branch/BranchTypeInfo.aspx">Branch Type Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    9.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink9" runat="server" NavigateUrl="~/Admin/Setup/Supplier/SupplierInfo.aspx">Supplier Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    10.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink10" runat="server" NavigateUrl="~/Admin/Setup/Member/MemberInfo.aspx">Member Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
        </table>
        <br />
   
    </div>
</asp:Content>

