<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme="DPOSThemes"  MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BranchTypeInfo.aspx.cs" Inherits="ui_setup_BranchTypeInfo" Title="::.. Branch Type Info ..::" %>
<%@ Import Namespace="System.Collections" %>

<%@ Import Namespace="DSL.POS.DTO.DTO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<script language="javascript" type ="text/javascript">
//var newwindow;
//function popWindow(url)
//{
//	newwindow=window.open(url,'name','scrollbars=1,resizable=1,left=300,right=50,top=300,height=200,width=600' );
//	if (window.focus) {newwindow.focus()}
//     
//}

function FocusControl_byEnter()
{
    if(event.keyCode==13)
    {
        if (document.activeElement.id =="ctl00_MainContent_txtBT_Name")
        {
           document.getElementById("ctl00_MainContent_btnAdd").focus();
        }

    }
}

</script>




<div id="masterDiv" class="DPOSStyleSheet.css" >
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top">
        &nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr align="left" valign="top"> 
          <td style="width: 5%">&nbsp;</td>
          <td width="96%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" valign="top"><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label></td>
              </tr>
              <tr> 
                <td align="left" valign="top">
                    &nbsp;</td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr align="left" valign="top"> 
                      <td  style="width:5%;">
                <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label></td>
                      <td  style="width:20%; height: 24px;">
                <asp:TextBox ID="txtBT_Code" runat="server" Width="230px" style="background-color: infobackground; vertical-align: top;" ReadOnly="True" BorderStyle="Solid" BorderWidth="1px" MaxLength="1"></asp:TextBox>
    <input type="button" name="button" value="..." onclick= 'window.open("BranchTypePopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' style="font-weight: bold; width: 30px; height: 22px"/>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%">
                <asp:Label ID="Label2" runat="server" Text="Name" Width="40px"></asp:Label></td>
                      <td width="51%" style="height: 24px">
                <asp:TextBox ID="txtBT_Name" runat="server" Width="262px" BorderStyle="Solid" BorderWidth="1px" MaxLength="50"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBT_Name"
                              ErrorMessage="Please enter branch type." ToolTip="Required!" ValidationGroup="BranchTypeGroupField" Width="5px" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%">&nbsp;</td>
                      <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr align="left" valign="top"> 
                            <td style="height: 24px; width: 9%;"><asp:Button ID="btnAdd" runat="server"
                    Text="Save" Width="64px" ValidationGroup="BranchTypeGroupField" OnClick="btnAdd_Click" UseSubmitBehavior="False" /></td>
                            <td style="height: 24px" width="85%"><asp:Button ID="btnCancel" runat="server"
                    Text="Cancel" Width="64px" OnClick="btnCancel_Click" UseSubmitBehavior="False" /></td>
                          </tr>
                        </table>
                      </td>
                    </tr>
                    
                    <tr align="left" valign="top">
                        <td style="width: 5%; height: 19px;">
                        </td>
                        <td style="height: 19px">
                            </td>
                    </tr>
                  </table>
                    &nbsp;</td>
              </tr>
              <tr>
                <td align="left" valign="top" >
    <asp:GridView ID="GridView1" 
    runat="server" 
    AutoGenerateColumns="False" 
    DataSourceID="ObjectDataSource1"
    OnRowCommand ="GridView1_RowEditing"
    OnRowDataBound = "GridView1_RowDataBound"
    OnRowEditing="GridView1_BeforeEditing"
    SkinID="Skin1" DataKeyNames="PrimaryKey" UseAccessibleHeader="False" Width="474px" OnRowDeleted="GridView1_RowDeleted">
        <Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="BT_Code" SortExpression="BT_Code" HeaderText="Code">
<ItemStyle Width="80px" Wrap="True" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="BT_Name" SortExpression="BT_Name" HeaderText="Branch Type Name">
<ItemStyle Width="60%" Wrap="True"></ItemStyle>
</asp:BoundField>
<asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
</Columns>
    </asp:GridView>
    </td>
              </tr>
              <tr> 
                <td align="left" valign="top"></td>
              </tr>
            </table></td>
          <td width="2%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top"></td>
  </tr>
</table>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="showDataBranchTypeInfo" TypeName="DSL.POS.BusinessLogicLayer.Imp.BranchTypeInfoBLImp" DataObjectTypeName="DSL.POS.DTO.DTO.BranchTypeInfoDTO" DeleteMethod="deleteBranchTypeRecord">
    </asp:ObjectDataSource>
    <asp:HiddenField ID="txtBT_PK" runat="server" />
                          <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                              ShowSummary="False" ValidationGroup="BranchTypeGroupField" Width="227px" DisplayMode="SingleParagraph" />
</div> 
</asp:Content>

