<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_Setup_Product_Default, App_Web_zyhzjyic" title="Untitled Page" %>
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
                    All Product pages link<br />
            <br />
        </strong></span>
        </span>
        <table style="font-weight: bold;">
            <tr>
                <td style="width: 10%; text-align: center">
                    <span style="font-size: 12pt"></span>
                </td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink11" runat="server" Font-Size="12pt" ForeColor="Fuchsia"
                        NavigateUrl="~/Admin/Default.aspx">Go to Setup Home</asp:HyperLink></td>
                <td style="width: 50%; text-align: left;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    1.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink4" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductCategoryInfo.aspx">Product Category  Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    2.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink5" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductSubCategoryInfo.aspx">Product Sub Category  Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    3.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink6" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductUnitInfo.aspx">Product Unit Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
            <tr>
                <td style="width: 10%; text-align: center">
                    4.</td>
                <td style="width: 40%; text-align: left">
                    <asp:HyperLink id="HyperLink7" runat="server" NavigateUrl="~/Admin/Setup/Product/ProductInfo.aspx">Product Information</asp:HyperLink></td>
                <td style="width: 50%;">
                </td>
            </tr>
        </table>
        <br />
    </span>
    </div>
</asp:Content>
