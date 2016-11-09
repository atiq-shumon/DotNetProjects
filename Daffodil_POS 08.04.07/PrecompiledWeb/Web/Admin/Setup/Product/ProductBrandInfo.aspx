<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="ui_setup_ProductBrandInfo, App_Web_zyhzjyic" title="Product Brand Info Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css">

<script language="javascript" type="text/javascript">



function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_txtBrandName")
        {
        document.getElementById('ctl00_MainContent_btnAdd').focus();
        }
    }
}


</script>


<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top" style="height: 19px">
        &nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr align="left" valign="top"> 
          <td style="width: 10%">&nbsp;</td>
          <td width="96%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" valign="top"><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label>
                    <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="height: 19px">
                    &nbsp;</td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr align="left" valign="top"> 
                      <td  style="width:7%">
                <asp:Label ID="Label1" runat="server" Style="top: 1px" Text="Code" Width="38px"></asp:Label></td>
                      <td  style="width:85%">
                <asp:TextBox ID="txtBrandCode" runat="server" Width="241px" style="background-color: infobackground; vertical-align: top;" BorderStyle="Solid" BorderWidth="1px" ReadOnly="True" MaxLength="4"></asp:TextBox><!--<asp:Button ID="btnFind" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" />--><input type="button" name="button" value="..." onclick= 'window.open("ProductBandPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' style="font-weight: bold; width: 30px; height: 22px"/>                          
                          </td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 7%; height: 26px;">
                <asp:Label ID="Label2" runat="server" Style="top: 1px" Text="Name"></asp:Label></td>
                      <td width="51%" style="width: 85%; height: 26px;">
                <asp:TextBox ID="txtBrandName" runat="server" Width="274px" BorderStyle="Solid" BorderWidth="1px" MaxLength="50"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBrandName"
                              ErrorMessage="Please enter brand name." ToolTip="Required!" ValidationGroup="ProductBrandTextField"
                              Width="5px" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 7%">&nbsp;</td>
                      <td style="width: 85%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr align="left" valign="top"> 
                            <td style="height: 24px; width: 10%;"><asp:Button ID="btnAdd" runat="server"
                    Text="Save" Width="65px" OnClick="btnSave_Click" ValidationGroup="ProductBrandTextField" UseSubmitBehavior="False" /></td>
                            <td style="height: 24px" width="85%"><asp:Button ID="btnCancel" runat="server"
                    Text="Cancel" Width="65px" OnClick="btnCancel_Click" UseSubmitBehavior="False" /></td>
                          </tr>
                        </table></td>
                    </tr>
                  </table>
                    &nbsp;</td>
              </tr>
              <tr>
                <td align="left" valign="top" >
    <asp:GridView ID="GridView1" 
        runat="server" 
        DataKeyNames="PrimaryKey"
        DataSourceID="ObjectDataSource1" 
        OnRowCommand="GridView1_RowEditing"
        OnRowEditing="GridView1_BeforeEditing"
        OnRowDataBound="GridView1_RowDataBound" 
        SkinID="Skin1" Width="472px" OnRowDeleted="GridView1_RowDeleted">
        <Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="PB_Code" HeaderText="Code">
<ItemStyle Width="20%" Wrap="False" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>

<FooterStyle BackColor="White"></FooterStyle>
</asp:BoundField>
<asp:BoundField DataField="PB_Name" HeaderText="Name">
<ItemStyle Width="60%" Wrap="False"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:CommandField UpdateText="" SelectText="" NewText="" ShowCancelButton="False" CancelText="" InsertText="" DeleteText="" ButtonType="Button" ShowEditButton="True"></asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
</Columns>
        <HeaderStyle HorizontalAlign="Center" Wrap="True" />
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

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetProductBrand"
        TypeName="DSL.POS.BusinessLogicLayer.Imp.ProductBrandBLImp" DataObjectTypeName="DSL.POS.DTO.DTO.ProductBrandInfoDTO" DeleteMethod="DelProductBrand"></asp:ObjectDataSource>
    <asp:HiddenField ID="hfPrimaryKey" runat="server" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
        ShowSummary="False" ValidationGroup="ProductBrandTextField" />
 </div> 
</asp:Content>

