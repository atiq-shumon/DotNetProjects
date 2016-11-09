<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BranchTypePopup.aspx.cs" Inherits="BranchTypePopup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >


<head id="Head1" runat="server">

<script language="javascript" type="text/javascript" >
//java Script here
</script>
<title>Untitled Page</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <table width="70%">
    <tr>   
        <td style="width: 130px">
            <asp:Label ID="Label1" runat="server" Text="Branch Type Code"></asp:Label></td>
    <td >
        <asp:TextBox ID="txtBranchTypeCode" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 130px" >
            <asp:Label ID="Label2" runat="server" Text="Branch Type Name"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtBranchTypeName" runat="server"></asp:TextBox></td>
    </tr>
        <tr>
            <td style="width: 130px">
            </td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="356px">
                    <Columns>
                        <asp:BoundField  HeaderStyle-BackColor="gray" DataField="BT_CODE" HeaderText="Branch Type Code">
                            
                        </asp:BoundField>
                        <asp:BoundField HeaderStyle-BackColor="gray" DataField="BT_NAME" HeaderText="Branch Type Name" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="showDataBranchTypeInfo"
                    TypeName="DSL.POS.BusinessLogicLayer.Imp.BranchTypeInfoBLImp"></asp:ObjectDataSource>
            </td>
           
        </tr>
    </table>
    </div>
    </form>
</body>
</html>