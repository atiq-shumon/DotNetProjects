<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme="DPOSThemes" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductUnitInfo.aspx.cs" Inherits="ui_setup_ProductUnitInfo" Title="::.. Product Unit Info ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css">
<script language ="javascript" type="text/javascript">

function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_txtPU_Name")
        {
        document.getElementById('ctl00_MainContent_btnAdd').focus();
        }


    }
}
</script>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top">&nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top"><table width="100%">
        <tr>
          <td style="width: 5%">&nbsp;</td>
          <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" valign="top"><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label>
                    <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%">
                    <tr>
                        <td style="width: 8%">
                            &nbsp;</td>
                        <td style="vertical-align: top; width: 50%; text-align: left">
                        </td>
                    </tr>
                    <tr> 
                      <td style="width: 8%"><asp:Label ID="Label1" text="Code" runat="server"></asp:Label></td>
                      <td style="vertical-align: top; width: 50%; text-align: left">
                          <asp:TextBox ID="txtPU_Code" runat="server" BorderStyle="Solid" BorderWidth="1px" Style="background-color: infobackground; vertical-align: top;" Width="169px" ReadOnly="True" MaxLength="2"></asp:TextBox><!--<asp:Button ID="btnFind" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" />--><input type="button" name="button" value="..." onclick= 'window.open("ProductUnitInfoPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' style="font-weight: bold; width: 30px; height: 22px"/>                          
                          </td>
                    </tr>
                    <tr> 
                      <td style="width: 8%; vertical-align: top; height: 23px; text-align: left;"><asp:Label ID="Label2" text="Name" runat="server"></asp:Label></td>
                      <td style="vertical-align: top; width: 50%; text-align: left"><asp:TextBox ID="txtPU_Name" runat="server" Width="203px" BorderStyle="Solid" BorderWidth="1px" MaxLength="50" ></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPU_Name"
                              ErrorMessage="Please enter product unit name." ToolTip="Required!" ValidationGroup="ProductUnitTextField" Width="5px" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
					<tr> 
                      <td style="width: 8%">&nbsp;</td>
                      <td style="vertical-align: top; width: 50%; text-align: left"><asp:Button ID="btnAdd" runat="server" Text="Save" OnClick="btnAdd_Click" ValidationGroup="ProductUnitTextField" Width="65px" UseSubmitBehavior="False" />&nbsp;<asp:Button
                              ID="btnCancel" runat="server" Text="Cancel" Width="65px" OnClick="btnCancel_Click" UseSubmitBehavior="False" AccessKey="c" /></td>
                    </tr>
                  </table>
                    &nbsp;</td>
              </tr>

              <tr>
                <td align="left" valign="top"><asp:GridView ID="GridView1" 
    runat="server" 
    AutoGenerateColumns="False" 
    DataSourceID="ObjectDataSource1"
    DataKeyNames="PrimaryKey"
    OnRowCommand ="GridView1_RowEditing"
    OnRowDataBound = "GridView1_RowDataBound"
    OnRowEditing="GridView1_BeforeEditing" SkinID="Skin1" Width="485px" OnRowDeleted="GridView1_RowDeleted">
        <Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="PU_Code" SortExpression="PU_Code" HeaderText="Code">
<ItemStyle Width="20%" Wrap="False" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="PU_Name" SortExpression="PU_Name" HeaderText="Name">
<ItemStyle Width="60%" Wrap="False"></ItemStyle>
</asp:BoundField>
<asp:CommandField UpdateText="" SelectText="" NewText="" ShowCancelButton="False" CancelText="" InsertText="" DeleteText="" ButtonType="Button" ShowEditButton="True"></asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
</Columns>
    </asp:GridView></td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="height: 19px">
                    &nbsp;</td>
              </tr>
            </table></td>
          <td width="2%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top">&nbsp;</td>
  </tr>
</table>
<asp:ObjectDataSource 
    ID="ObjectDataSource1" 
    runat="server" 
    DataObjectTypeName="DSL.POS.DTO.DTO.ProductUnitInfoDTO"
    DeleteMethod="deleteProductUnit"  
    SelectMethod="GetProductUnitInfo"
    TypeName="DSL.POS.BusinessLogicLayer.Imp.ProductUnitBLImpl">
    </asp:ObjectDataSource>
    <asp:HiddenField ID="txtPU_PK" runat="server" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph"
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="ProductUnitTextField" />

</div> 
</asp:Content>

