<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme="DPOSThemes" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductInfo.aspx.cs" Inherits="ui_setup_ProductInfo" Title="::.. Product Info ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<SCRIPT language="JavaScript" src="../../../JavaScript/calendar.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../../JavaScript/calendar-en.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../../JavaScript/calendar-setup.js"></SCRIPT>

<DIV id="masterDiv" class="StyleSheet.css"><TABLE style="WIDTH: auto; HEIGHT: auto" cellSpacing=0 cellPadding=0 border=0><TBODY><TR><TD vAlign=top align=left>&nbsp;</TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="HEIGHT: auto" width="2%">&nbsp;</TD><TD style="HEIGHT: auto"><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD vAlign=top align=left><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></TD></TR><TR><TD vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 7%"><asp:Label id="Label4" runat="server" Width="89px" Text="Product Code"></asp:Label></TD><TD style="WIDTH: 80%"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtProductCode" runat="server" Width="248px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" CausesValidation="True" MaxLength="13"></asp:TextBox> <!--<asp:Button ID="btnFind" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" />--><INPUT style="FONT-WEIGHT: bold; WIDTH: 30px; HEIGHT: 22px" onclick='window.open("ProductInfoPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' type=button value="..." name="button" /> </TD><TD style="WIDTH: 138px; HEIGHT: 24px"></TD></TR><TR><TD style="WIDTH: 7%" vAlign=top align=left><asp:Label id="Label1" runat="server" Width="113px" Text="Product Category"></asp:Label></TD><TD style="WIDTH: 80%"><asp:DropDownList id="ddlProductCategory" runat="server" Width="286px"></asp:DropDownList>&nbsp; <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="ddlProductCategory" ErrorMessage="Select a category" ValidationGroup="ProductGroupTextField" SetFocusOnError="True">*</asp:RequiredFieldValidator> <asp:Button id="btnClickProductCategory" onclick="btnClickProductCategory_Click" runat="server" Width="1px" Height="1px" Text="." __designer:wfdid="w1" UseSubmitBehavior="False"></asp:Button></TD><TD style="WIDTH: 138px"></TD></TR><TR><TD style="WIDTH: 7%"><asp:Label id="Label2" runat="server" Width="141px" Text="Product Sub Category"></asp:Label></TD><TD style="WIDTH: 80%"><asp:DropDownList id="ddlProductSubCategory" runat="server" Width="286px"></asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ControlToValidate="ddlProductSubCategory" ErrorMessage="Select a sub category" ValidationGroup="ProductGroupTextField" SetFocusOnError="True" Enabled="False">*</asp:RequiredFieldValidator></TD><TD style="WIDTH: 138px"></TD></TR><TR><TD style="WIDTH: 7%"><asp:Label id="Label3" runat="server" Width="101px" Text="Product Brand"></asp:Label></TD><TD style="WIDTH: 80%"><asp:DropDownList id="ddlProductBrand" runat="server" Width="286px"> 
                        </asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ControlToValidate="ddlProductBrand" ErrorMessage="Select a brand" ValidationGroup="ProductGroupTextField" SetFocusOnError="True" Enabled="False" Visible="False">*</asp:RequiredFieldValidator></TD><TD style="WIDTH: 138px; HEIGHT: 23px"></TD></TR><TR><TD style="WIDTH: 7%"><asp:Label id="Label5" runat="server" Width="94px" Text="Product Name"></asp:Label></TD><TD style="WIDTH: 80%"><asp:TextBox id="txtProductName" runat="server" Width="445px" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="75"></asp:TextBox> <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="5px" ControlToValidate="txtProductName" ErrorMessage="Enter product name." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="Required!">*</asp:RequiredFieldValidator></TD><TD style="WIDTH: 138px; HEIGHT: 24px"></TD></TR><TR><TD style="WIDTH: 7%"><asp:Label id="Label6" runat="server" Text="Style"></asp:Label></TD><TD style="WIDTH: 80%"><asp:TextBox id="txtStyle" runat="server" Width="446px" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="100"></asp:TextBox> </TD><TD style="WIDTH: 138px"></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 141px"><asp:Label id="Label7" runat="server" Text="Sales Price"></asp:Label></TD><TD style="WIDTH: 187px"><asp:TextBox id="txtSalesPrice" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox> <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" Width="5px" ControlToValidate="txtSalesPrice" ErrorMessage="Enter a sales price" ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="Sales price can't be blank!">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Font-Bold="True" ControlToValidate="txtSalesPrice" ErrorMessage="You must enter a valid price." ValidationGroup="ProductGroupTextField" ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="WIDTH: 104px"><asp:Label id="Label16" runat="server" Text="Sales Price Date"></asp:Label></TD><TD><asp:TextBox style="VERTICAL-ALIGN: top" id="txtSalesPriceDate" runat="server" Width="110px" BorderStyle="Solid" BorderWidth="1px" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox><IMG style="VERTICAL-ALIGN: top" id="imgSalesPriceDate" alt="Pick Date" src="../../../Images/calendar.gif" /> <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server" Width="5px" ControlToValidate="txtSalesPriceDate" ErrorMessage="Enter a Sales price Date" ValidationGroup="ProductGroupTextField" SetFocusOnError="True" __designer:wfdid="w8" ToolTip="Sales price Date can't be blank!">*</asp:RequiredFieldValidator><asp:RangeValidator id="RangeValidator1" runat="server" ControlToValidate="txtSalesPriceDate" ErrorMessage="*" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" __designer:wfdid="w9" ToolTip="Please enter a valid date." Type="Date" MaximumValue="01/01/2999" MinimumValue="01/01/1973"></asp:RangeValidator>
<SCRIPT language="javascript" type="text/javascript">
                              Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
                              
                              function pageLoadedHandler(sender, args) 
                                { SetMyCalendar_Sales(); }
                              function EndRequestHandler(sender, args) 
                                { SetMyCalendar_Sales();}
                              function SetMyCalendar_Sales() 
                              {
                                if (document.getElementById("ctl00_MainContent_txtSalesPriceDate") )
                                {
                                    Calendar.setup(
                                    {
                                        inputField  : "ctl00_MainContent_txtSalesPriceDate",      
                                        ifFormat    : "mm/dd/y",    
                                        button      : "imgSalesPriceDate",   
                                        weekNumbers : false
                                    }
                                    );    
                                }   
                               }	    
	    
                        </SCRIPT>
 </TD></TR><TR><TD style="WIDTH: 141px"><asp:Label id="Label9" runat="server" Text="Tax"></asp:Label></TD><TD style="WIDTH: 187px"><asp:TextBox id="txtTax" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox>&nbsp; <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" Font-Bold="True" ControlToValidate="txtTax" ErrorMessage="You must enter a valid number." ValidationGroup="ProductGroupTextField" ToolTip="You must enter a valid number." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="WIDTH: 104px"><asp:Label id="Label10" runat="server" Text="Vat"></asp:Label></TD><TD><asp:TextBox id="txtVat" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox>&nbsp; <asp:RegularExpressionValidator id="RegularExpressionValidator5" runat="server" Font-Bold="True" ControlToValidate="txtVat" ErrorMessage="You must enter a valid price." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 141px"><asp:Label id="Label13" runat="server" Text="Max Level"></asp:Label></TD><TD style="WIDTH: 187px"><asp:TextBox id="txtMaxLevel" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox>&nbsp; <asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" Font-Bold="True" ControlToValidate="txtMaxLevel" ErrorMessage="You must enter a valid number." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid number." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="WIDTH: 104px"><asp:Label id="Label12" runat="server" Text="Min Level"></asp:Label></TD><TD><asp:TextBox id="txtMinLevel" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox>&nbsp; <asp:RegularExpressionValidator id="RegularExpressionValidator10" runat="server" Font-Bold="True" ControlToValidate="txtMinLevel" ErrorMessage="You must enter a valid number." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid number." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 141px"><asp:Label id="Label8" runat="server" Text="Cost Price"></asp:Label></TD><TD style="WIDTH: 187px"><asp:TextBox id="txtCostPrice" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox> <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" Width="5px" ControlToValidate="txtCostPrice" ErrorMessage="Enter cost price" ValidationGroup="ProductGroupTextField" ToolTip="Required!">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator4" runat="server" Font-Bold="True" ControlToValidate="txtCostPrice" ErrorMessage="You must enter a valid price." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="WIDTH: 104px"><asp:Label id="Label17" runat="server" Text="Cost Price Date"></asp:Label></TD><TD><asp:TextBox style="VERTICAL-ALIGN: top" id="txtCostPriceDate" runat="server" Width="111px" BorderStyle="Solid" BorderWidth="1px" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox><IMG style="VERTICAL-ALIGN: top" id="imgCostPriceDate" alt="Pick Date" src="../../../Images/calendar.gif" /> <asp:RequiredFieldValidator id="RequiredFieldValidator9" runat="server" Width="5px" ControlToValidate="txtCostPriceDate" ErrorMessage="Enter a Cost price Date" ValidationGroup="ProductGroupTextField" SetFocusOnError="True" __designer:wfdid="w11" ToolTip="Cost price Date can't be blank!">*</asp:RequiredFieldValidator><asp:RangeValidator id="RangeValidator2" runat="server" ControlToValidate="txtCostPriceDate" ErrorMessage="*" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" __designer:wfdid="w10" ToolTip="Please enter a valid date." Type="Date" MaximumValue="01/01/2999" MinimumValue="01/01/1973"></asp:RangeValidator>
<SCRIPT language="javascript" type="text/javascript">
                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
                              
                              function pageLoadedHandler(sender, args) 
                                { SetMyCalendar(); }
                              function EndRequestHandler(sender, args) 
                                { SetMyCalendar();}
                              function SetMyCalendar() 
                              {
                                if (document.getElementById("ctl00_MainContent_txtCostPriceDate") )
                                {
                                    Calendar.setup(
                                    {
                                        inputField  : "ctl00_MainContent_txtCostPriceDate",      
                                        ifFormat    : "mm/dd/y",    
                                        button      : "imgCostPriceDate",   
                                        weekNumbers : false
                                    }
                                    );    
                                }   
                               }		    
                        </SCRIPT>
 </TD></TR><TR><TD style="WIDTH: 141px"><asp:Label id="Label11" runat="server" Text="Discount"></asp:Label></TD><TD style="WIDTH: 187px"><asp:TextBox id="txtDiscount" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox>&nbsp; <asp:RegularExpressionValidator id="RegularExpressionValidator6" runat="server" Font-Bold="True" ControlToValidate="txtDiscount" ErrorMessage="You must enter a valid price." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="WIDTH: 104px"><asp:Label id="Label18" runat="server" Text="Unit"></asp:Label></TD><TD><asp:DropDownList id="ddlProductUnit" runat="server" Width="154px"> 
                        </asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ControlToValidate="ddlProductUnit" ErrorMessage="Select a unit" ValidationGroup="ProductGroupTextField" SetFocusOnError="True" Visible="False">*</asp:RequiredFieldValidator></TD></TR><TR><TD style="WIDTH: 141px"><asp:Label id="Label14" runat="server" Text="Reorder Level"></asp:Label></TD><TD style="WIDTH: 187px"><asp:TextBox id="txtReorderLevel" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="14"></asp:TextBox>&nbsp; <asp:RegularExpressionValidator id="RegularExpressionValidator7" runat="server" Font-Bold="True" ControlToValidate="txtReorderLevel" ErrorMessage="You must enter a valid number." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid number." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="DISPLAY: none" id="tdHide" colSpan=2><asp:Label id="Label19" runat="server" Text="Warranty Month"></asp:Label>&nbsp; <asp:TextBox id="txtWarrantyMonth" runat="server" BorderStyle="Solid" BorderWidth="1px" CausesValidation="True" MaxLength="4"></asp:TextBox><asp:RegularExpressionValidator id="RegularExpressionValidator8" runat="server" Font-Bold="True" ControlToValidate="txtWarrantyMonth" ErrorMessage="You must enter a valid number." ValidationGroup="ProductGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid number." ValidationExpression="\d+">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 141px"></TD><TD style="WIDTH: 187px"><INPUT id="chkWarranty" type=checkbox value="" runat="server" /><asp:Label id="Label15" runat="server" Text="Warranty"></asp:Label></TD><TD style="WIDTH: 104px"><asp:CheckBox id="chkStatus" runat="server" Text="Active Status"></asp:CheckBox></TD><TD></TD></TR><TR><TD style="WIDTH: 141px"></TD><TD style="WIDTH: 187px"><asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="65px" Text="Save" ValidationGroup="ProductGroupTextField" UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnCancel" onclick="btnCancel_Click" runat="server" Width="65px" Text="Cancel" UseSubmitBehavior="False"></asp:Button></TD><TD style="WIDTH: 104px"></TD><TD></TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE><DIV style="OVERFLOW: auto; WIDTH: 709px; HEIGHT: 197px"><asp:GridView id="GridView1" runat="server" Width="689px" DataSourceID="ObjectDataSource1" DataKeyNames="PrimaryKey" OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_BeforeEditing" OnRowDataBound="GridView1_RowDataBound" AutoGenerateColumns="False" SkinID="Skin1" OnRowDeleted="GridView1_RowDeleted" AllowPaging="True"><Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="P_Code" SortExpression="P_Code" HeaderText="Code">
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_Name" SortExpression="P_Name" HeaderText="Name">
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_Style" Visible="False" SortExpression="P_Style" HeaderText="Style"></asp:BoundField>
<asp:BoundField DataField="P_SalesPrice" SortExpression="P_SalesPrice" HeaderText="Sales Price">
<ItemStyle HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_CostPrice" SortExpression="P_CostPrice" HeaderText="Cost Price">
<ItemStyle HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_MaxLevel" Visible="False" SortExpression="P_MaxLevel" HeaderText="Max Level"></asp:BoundField>
<asp:CheckBoxField DataField="P_Warranty" Visible="False" SortExpression="P_Warranty" HeaderText="Warranty"></asp:CheckBoxField>
<asp:BoundField DataField="P_ReorderLevel" Visible="False" SortExpression="P_ReorderLevel" HeaderText="Reorder Level"></asp:BoundField>
<asp:BoundField DataField="P_CostPriceDate" Visible="False" SortExpression="P_CostPriceDate" HeaderText="Cost Price Date"></asp:BoundField>
<asp:BoundField DataField="P_Discount" SortExpression="P_Discount" HeaderText="Discount">
<ItemStyle HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_VAT" SortExpression="P_VAT" HeaderText="VAT">
<ItemStyle HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_SalesPriceDate" Visible="False" SortExpression="P_SalesPriceDate" HeaderText="Sales Price Date"></asp:BoundField>
<asp:CheckBoxField DataField="P_Status" Visible="False" SortExpression="P_Status" HeaderText="Status"></asp:CheckBoxField>
<asp:BoundField DataField="P_Tax" SortExpression="P_Tax" HeaderText="Tax">
<ItemStyle HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="P_MinLevel" Visible="False" SortExpression="P_MinLevel" HeaderText="Min Level"></asp:BoundField>
<asp:BoundField DataField="P_WarrantyMonth" Visible="False" SortExpression="P_WarrantyMonth" HeaderText="WarrantyMonth"></asp:BoundField>
<asp:CommandField UpdateText="" SelectText="" NewText="" ShowCancelButton="False" CancelText="" InsertText="" DeleteText="" ButtonType="Button" ShowEditButton="True"></asp:CommandField>
<asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
</Columns>
</asp:GridView>&nbsp; </DIV><asp:ObjectDataSource id="ObjectDataSource1" runat="server" SelectMethod="GetProductInfo" TypeName="DSL.POS.BusinessLogicLayer.Imp.ProductInfoBLImp" DataObjectTypeName="DSL.POS.DTO.DTO.ProductInfoDTO" DeleteMethod="DelProductInfo"></asp:ObjectDataSource> <asp:HiddenField id="hfPrimaryKey" runat="server"></asp:HiddenField> <asp:ValidationSummary id="ValidationSummary1" runat="server" Width="159px" Height="27px" ValidationGroup="ProductGroupTextField" __designer:wfdid="w1" ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary></TD><TD style="WIDTH: 1%; HEIGHT: auto">&nbsp;</TD></TR></TBODY></TABLE></TD></TR><TR><TD vAlign=top align=left></TD></TR></TBODY></TABLE></DIV>
</ContentTemplate>
        </asp:UpdatePanel>
<script language="javascript" type="text/javascript">
//function WarrantyCheck(){
//		{
//if(document.getElementById('chkWarranty').checked)
//document.getElementById('tdHide').style['display']='none';
//else
//document.getElementById('tdHide').style['display']='';
//return false;
//}
//	}

//function doNumericWithFloat()
//{
//if(event.keyCode<46||event.keyCode==47||event.keyCode>57)event.returnValue=false;
//}
//function doNumeric()
//{
//if(event.keyCode<48||event.keyCode>57)event.returnValue=false;
//}


function clickbtn(btnctrl)
	{
		if (event.keyCode==13)
		{
		    document.getElementById(btnctrl).click();						
		    return false;
		}
	}		
	
	//For Formating From Date Field
function formatSalesPriceDateField(){
    var value=document.getElementById("ctl00_MainContent_txtSalesPriceDate").value;
    if(value.length==2){
      document.getElementById("ctl00_MainContent_txtSalesPriceDate").value=document.getElementById("ctl00_MainContent_txtSalesPriceDate").value+"/";
    } else if(value.length==5){
      document.getElementById("ctl00_MainContent_txtSalesPriceDate").value=document.getElementById("ctl00_MainContent_txtSalesPriceDate").value+"/20";
    }
}
//For Formating To Date Field
function formatCostPriceDateField(){
    var value=document.getElementById("ctl00_MainContent_txtCostPriceDate").value;
    if(value.length==2){
      document.getElementById("ctl00_MainContent_txtCostPriceDate").value=document.getElementById("ctl00_MainContent_txtCostPriceDate").value+"/";
    } else if(value.length==5){
      document.getElementById("ctl00_MainContent_txtCostPriceDate").value=document.getElementById("ctl00_MainContent_txtCostPriceDate").value+"/20";
    }
}

function FocusControl_byEnter()
{
if(event.keyCode==13)
     {        
        if (document.activeElement.id=="ctl00_MainContent_ddlProductSubCategory")
        {
        document.getElementById('ctl00_MainContent_ddlProductBrand').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_ddlProductBrand")
        {
        document.getElementById('ctl00_MainContent_txtProductName').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtProductName")
        {
        document.getElementById('ctl00_MainContent_txtStyle').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtStyle")
        {
        document.getElementById('ctl00_MainContent_txtSalesPrice').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtSalesPrice")
        {
        document.getElementById('ctl00_MainContent_txtSalesPriceDate').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtSalesPriceDate")
        {
        document.getElementById('ctl00_MainContent_txtTax').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtTax")
        {
        document.getElementById('ctl00_MainContent_txtVat').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtVat")
        {
        document.getElementById('ctl00_MainContent_txtMaxLevel').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtMaxLevel")
        {
        document.getElementById('ctl00_MainContent_txtMinLevel').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtMinLevel")
        {
        document.getElementById('ctl00_MainContent_txtCostPrice').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtCostPrice")
        {
        document.getElementById('ctl00_MainContent_txtCostPriceDate').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtCostPriceDate")
        {
        document.getElementById('ctl00_MainContent_txtDiscount').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtDiscount")
        {
        document.getElementById('ctl00_MainContent_ddlProductUnit').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_ddlProductUnit")
        {
        document.getElementById('ctl00_MainContent_txtReorderLevel').focus();
        }
        
        else if (document.activeElement.id=="ctl00_MainContent_txtReorderLevel")
        {
        document.getElementById('ctl00_MainContent_chkWarranty').focus();
        }

        else if (document.activeElement.id=="ctl00_MainContent_chkWarranty")
        {
           if(document.getElementById('ctl00_MainContent_chkWarranty').checked)
           {
           document.getElementById('tdHide').style['display']='';
            document.getElementById('ctl00_MainContent_txtWarrantyMonth').focus();
            }
            else
            {
            document.getElementById('tdHide').style['display']='none';
            document.getElementById('ctl00_MainContent_chkStatus').focus();
            return false;
            }

        }
       
        else if (document.activeElement.id=="ctl00_MainContent_txtWarrantyMonth")
        {
        document.getElementById('ctl00_MainContent_chkStatus').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_chkStatus")
        {
        document.getElementById('ctl00_MainContent_btnSave').focus();
        }

    }
    else if(document.activeElement.id=="ctl00_MainContent_txtSalesPrice"
            ||document.activeElement.id=="ctl00_MainContent_txtCostPrice"
            ||document.activeElement.id=="ctl00_MainContent_txtTax"
            ||document.activeElement.id=="ctl00_MainContent_txtVat"
            ||document.activeElement.id=="ctl00_MainContent_txtDiscount"
            ||document.activeElement.id=="ctl00_MainContent_txtWarrantyMonth")
        {
            if (event.keyCode<46||event.keyCode==47||event.keyCode>57)
            {
            event.returnValue=false;
            }
        }
    else if(document.activeElement.id=="ctl00_MainContent_txtQuantity"
            ||document.activeElement.id=="ctl00_MainContent_txtMinLevel"
            ||document.activeElement.id=="ctl00_MainContent_txtMaxLevel"
            ||document.activeElement.id=="ctl00_MainContent_txtReorderLevel")
        {
            if (event.keyCode<48||event.keyCode>57)
            {
            event.returnValue=false;
            }
        }
//    else if(document.activeElement.id=="ctl00_MainContent_chkWarranty")
//        {
//            if(document.getElementById('ctl00_MainContent_chkWarranty').checked)
//            document.getElementById('tdHide').style['display']='none';
//            else
//            document.getElementById('tdHide').style['display']='';
//            return false;
//            
//        }


}

		
</script>
</asp:Content>

