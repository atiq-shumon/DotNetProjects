<%@ page language="C#" theme="DPOSThemes" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="ui_setup_ProductCategoryInfo, App_Web_zyhzjyic" title="Product Category Info" stylesheettheme="DPOSThemes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<div id="masterDiv" class="DPOSStyleSheet.css" >

<script language="javascript" type="text/javascript">


function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_txtCategoryDescription")
        {
        document.getElementById('ctl00_MainContent_btnSave').focus();
        }
    }
}


    function test()
    {
        alert("Data Save Successfully.");
    }
</script>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr> 
    <td colspan="3" align="left" valign="top">
        &nbsp;</td>
  </tr>
  <tr> 
    <td align="left" valign="top" style="width: 6%">&nbsp;</td>
    <td width="96%" align="left" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr> 
         
        </tr>
        <tr> 
          <td align="left" valign="top"><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label>
              <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></td>
        </tr>
        <tr> 
          <td align="left" valign="top"><table width="100%">
              <tr> 
                <td align="right" style="width: 7%"> &nbsp;&nbsp;</td>
                <td width="49%"> &nbsp;</td>
              </tr>
              <tr>
                  <td style="width: 7%">
                      &nbsp;<asp:Label ID="Label2" runat="server" Text="Code"></asp:Label></td>
                  <td style="height: 22px">
                      &nbsp;<asp:TextBox ID="txtProductCategoryCode" runat="server" BorderStyle="Solid" BorderWidth="1px" Style="background-color: infobackground; vertical-align: top;" Width="239px" ReadOnly="True" MaxLength="2"></asp:TextBox>
                          <!--<asp:Button ID="btnFind" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" />-->
                         
    <input type="button" name="button" value="..." onclick= 'window.open("ProductCategoryPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' style="font-weight: bold; width: 30px; height: 22px"/>                          
                          
                          </td>
              </tr>
              <tr> 
                <td style="width: 7%;">
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="Description" Width="89px"></asp:Label></td>
                <td style="height: 22px">
                    &nbsp;<asp:TextBox ID="txtCategoryDescription"  MaxLength="50" runat="server" Width="272px" BorderStyle="Solid" BorderWidth="1px" OnTextChanged="txtCategoryDescription_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCategoryDescription"
                        ErrorMessage="Please enter product category description" ToolTip="Required!" ValidationGroup="ProductCategoryGroupField"
                        Width="5px" Display="Dynamic">*</asp:RequiredFieldValidator></td>
              </tr>
              <tr> 
                <td valign="top" style="width: 7%">&nbsp;</td>
                <td ><table width="100%">
                    <tr> 
                      <td align="left" valign="top" style="height: 26px; width: 8%;"><asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="65px" ValidationGroup="ProductCategoryGroupField" UseSubmitBehavior="False" /> 
                      </td>
                      <td width="70%" style="height: 26px"> <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Width="65px" UseSubmitBehavior="False" /> </td>
                    </tr>
                  </table></td>
              </tr>
            </table>
              &nbsp;</td>
        </tr>
        <tr>
          <td align="left" valign="top" style="height: 167px">    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
        DataSourceID="ObjectDataSource1" 
        OnRowCommand="GridView1_RowEdting"
        OnRowDataBound="GridView1_RowDataBound"        
        OnRowEditing="GridView1_BeforeEdting"         
        DataKeyNames="PrimaryKey" SkinID="Skin1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" UseAccessibleHeader="False" Width="457px" OnRowDeleted="GridView1_RowDeleted">
        <Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="PC_Code" SortExpression="PC_Code" HeaderText="Code">
<ItemStyle Width="20%" Wrap="False" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>

<FooterStyle Width="25px"></FooterStyle>
</asp:BoundField>
<asp:BoundField DataField="PC_Description" SortExpression="PC_Description" HeaderText="Description">
<ItemStyle Width="60%" Wrap="False"></ItemStyle>
</asp:BoundField>
<asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
</Columns>
    </asp:GridView>
</td>
        </tr>
        <tr> 
          <td align="left" valign="top">&nbsp;</td>
        </tr>
      </table></td>
    <td width="2%" align="left" valign="top">&nbsp;</td>
  </tr>
  <tr> 
    <td colspan="3" align="left" valign="top" ></td>
  </tr>
</table>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="showData"
        TypeName="DSL.POS.BusinessLogicLayer.Imp.ProductCategoryBLImp" DataObjectTypeName="DSL.POS.DTO.DTO.ProductCategoryInfoDTO" DeleteMethod="DeleteProduct"></asp:ObjectDataSource>
<asp:HiddenField ID="txtHideFieldPK" runat="server" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph"
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="ProductCategoryGroupField" />
</div> 
</asp:Content>

