<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Client_Purchase_Default" Title="::.. Purchase Main ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="masterDiv" class="DPOSStyleSheet.css" style="text-align: center" >
    <br />
    <span style="font-size: 24pt; color: #ffffff; background-color: #33ccff"><strong>::..This
        page is now underconstruction..::<br />
        <br />
                        <asp:HyperLink id="HyperLink2" runat="server" Font-Size="12pt" NavigateUrl="~/Default.aspx">Go To Home</asp:HyperLink><br />
    </strong>
        <span style="color: #000000; background-color: #ffffff">
            <table style="font-weight: bold; color: #000000; background-color: #ffffff" bordercolor="#cccccc">
                <tr>
                    <td style="width: 5%; text-align: center">
                    </td>
                    <td style="width: 80%; height: 37px">
                        **Purchase Information Pages**</td>
                    <td style="width: 400px; height: 37px">
                        </td>
                </tr>
                <tr>
                    <td style="width: 5%; height: 37px; text-align: center">
                    1.</td>
                    <td style="width: 80%; height: 37px; text-align: left">
                        <asp:HyperLink id="HyperLink6" runat="server" NavigateUrl="~/Client/Purchase/PurchaseInfo.aspx">Purchase Main</asp:HyperLink></td>
                    <td style="width: 400px; height: 37px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 5%; height: 37px; text-align: center">
                        2.</td>
                    <td style="width: 80%; height: 37px; text-align: left">
                        <asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="~/Client/Purchase/PurchaseReturn.aspx">Purchase Return</asp:HyperLink></td>
                    <td style="width: 400px; height: 37px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 5%; height: 37px; text-align: center">
                        3.</td>
                    <td style="width: 80%; height: 37px; text-align: left">
                        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Client/Purchase/OpeningBalance.aspx">Opening Balance</asp:HyperLink></td>
                    <td style="width: 400px; height: 37px">
                    </td>
                </tr>
            </table>
            <br />
        </span>
    </span>
    </div>
</asp:Content>

