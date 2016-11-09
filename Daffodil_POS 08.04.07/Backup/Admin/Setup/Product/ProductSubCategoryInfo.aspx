<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme="DPOSThemes" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductSubCategoryInfo.aspx.cs" Inherits="ui_setup_ProductSubCategoryInfo" Title="::.. Product Sub Category Info ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css">
<script language ="javascript" type="text/javascript">

function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_ddlProductCategory")
        {
        document.getElementById('ctl00_MainContent_txtPSubCategoryDescription').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtPSubCategoryDescription")
        {
        document.getElementById('ctl00_MainContent_btnSave').focus();
        }


    }
}
</script>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top">
        &nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top" style="height: 518px"><table width="100%">
        <tr>
          <td style="width: 10%">&nbsp;</td>
          <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" valign="top"><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label>
                    <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%" align="left">
                    <tr>
                        <td align="left" valign="top" style="width: 7%">
                            &nbsp;</td>
                        <td width="30%">
                        </td>
                    </tr>
                    <tr>
                        <td align="left" style="width: 7%" valign="top">
                            <asp:Label ID="Label3" runat="server" Text="Sub Category Code" Width="124px"></asp:Label></td>
                        <td width="30%">
                            <asp:TextBox ID="txtPSCCode" runat="server" BorderStyle="Solid" BorderWidth="1px" Style="background-color: infobackground; vertical-align: top;" Width="204px" ReadOnly="True" MaxLength="3"></asp:TextBox><!--<asp:Button ID="Button2" runat="server" Text="....." />--><input type="button" name="button" value="..." onclick= 'window.open("ProductSubCategoryPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' style="font-weight: bold; width: 30px; height: 22px"/>                                
                                </td>
                    </tr>
                    <tr> 
                      <td align="left" valign="top" style="width: 7%"> 
                        <asp:Label ID="Label1" runat="server"  Text="Category Name" ></asp:Label></td>
                      <td width="30%"><asp:DropDownList id="ddlProductCategory" runat="server" Width="242px"></asp:DropDownList>
                          <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="ddlProductCategory"
                              ErrorMessage="Select a Category Name!" SetFocusOnError="True" ToolTip="Select a category Name!" ValidationGroup="ProductSubCategoryTextField">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr> 
                      <td style="width: 7%; height: 24px;"><asp:Label ID="Label2" runat="server" Text="Sub Category Description" Width="162px" ></asp:Label> 
                      </td>
                      <td style="height: 24px"><asp:TextBox ID="txtPSubCategoryDescription" runat="server" BorderStyle="Solid" BorderWidth="1px" Width="238px" maxlength="50" ></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPSubCategoryDescription"
                              ErrorMessage="Please enter sub category description" ToolTip="Required!" ValidationGroup="ProductSubCategoryTextField"
                              Width="5px" Display="Dynamic" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr> 
                      <td style="width: 7%"></td>
                      <td align="left" valign="top"> 
                        <asp:Button ID="btnSave" runat="server" Text="Save" Width="63px" OnClick="btnSave_Click" ValidationGroup="ProductSubCategoryTextField" UseSubmitBehavior="False" />&nbsp;<asp:Button
                            ID="btnCancel" runat="server" Text="Cancel" Width="63px" OnClick="btnCancel_Click" UseSubmitBehavior="False" /></td>
                    </tr>                    
                    <tr>
                        <td style="width: 7%">
                            &nbsp;</td>
                        <td align="left" valign="top">
                        </td>
                    </tr>
                  </table></td>
              </tr>
              <tr>
                <td align="left" valign="top">    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2"
         OnRowCommand="GridView1_RowEdting"
        OnRowEditing="GridView1_BeforeEdting"    
        OnRowDataBound="GridView1_RowDataBound"    
       DataKeyNames="PrimaryKey" SkinID="Skin1" Width="515px" OnRowDeleted="GridView1_RowDeleted">
        <Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="PC_PK" Visible="False" SortExpression="PC_PK" HeaderText="PC_PK"></asp:BoundField>
<asp:BoundField DataField="PSC_Code" SortExpression="PSC_Code" HeaderText="Code">
<ItemStyle Width="20%" Wrap="False" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="PSC_Description" SortExpression="PSC_Description" HeaderText="Sub Category Description">
<ItemStyle Width="60%" Wrap="False"></ItemStyle>
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
          <td style="width: 1%">&nbsp;</td>
        </tr>
      </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
            ShowMessageBox="True" ShowSummary="False" ValidationGroup="ProductSubCategoryTextField"
            Width="232px" />
    </td>
  </tr>
  <tr>
    <td align="left" valign="top" style="height: 6px"></td>
  </tr>
</table>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="showDataSubCategoryInfo"
        TypeName="DSL.POS.BusinessLogicLayer.Imp.ProductSubCategoryInfoBLImp" DataObjectTypeName="DSL.POS.DTO.DTO.ProductSubCategoryInfoDTO" DeleteMethod="DeleteProductSubCategory"></asp:ObjectDataSource>

<asp:HiddenField ID="txtHideFieldPK" runat="server" />


</div> 
</asp:Content>

