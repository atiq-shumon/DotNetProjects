<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesInvoiceNoPopup.aspx.cs" Inherits="SalesInvoiceNoPopup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 85px">
            <tr>
                <td style="width: 72px; height: 22px;">
                    Invoice No</td>
                <td style="width: 78px; height: 22px;">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="237px">
                    </asp:DropDownList></td>
                <td style="width: 44px; height: 22px;">
                </td>
            </tr>
            <tr>
                <td style="width: 72px; height: 25px;">
                    Scarch No</td>
                <td style="width: 78px; height: 25px;">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td style="width: 44px; height: 25px;">
                </td>
            </tr>
            <tr>
                <td style="width: 72px; height: 23px;">
                </td>
                <td style="width: 78px; height: 23px;">
                </td>
                <td style="width: 44px; height: 23px;">
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
   <table width="70%" id="TABLE1">
    <tr>
    <td style="width: 105px">
        <asp:Label ID="Label1" runat="server" Text="Invoice No"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtInvoiceNo" runat="server"></asp:TextBox></td>
    </tr>   
    <tr>
    <td style="width: 105px">
        <asp:Label ID="Label2" runat="server" Text="Invoice Date"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtInvoiceDate" runat="server"></asp:TextBox></td>
    </tr>   
       <tr>
           <td style="width: 105px">
           </td>
           <td>
               <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
       </tr>
       <tr>
           <td colspan="2">
               <asp:GridView ID="GridView1" runat="server">
               </asp:GridView>
               <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
           </td>
       </tr>

   </table>
    
    </div>
    </form>
</body>
</html>
