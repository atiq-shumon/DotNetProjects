<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PurchaseReport.aspx.cs" Inherits="Report_Purchase_PurchaseReport" Title="::.. Purchase Report ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<SCRIPT language="JavaScript" src="../../JavaScript/calendar.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../JavaScript/calendar-en.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../JavaScript/calendar-setup.js"></SCRIPT>

<link href="../../JavaScript/calendar-system.css" rel="stylesheet" type="text/css" />
<script language="javascript" type="text/javascript">
//for enable disable texbox and drop down list
//for Specific Supplier
function doSpecificSupplier()
{
    if(document.getElementById('ctl00_MainContent_RbSpecificSupplier').checked=true)
    {
    
    //document.getElementById('ctl00_MainContent_RbAllSupplier').checked=false;
    document.getElementById('childTblSpecificSupplier').style['display']='';
    }
}
//for All Supplier
function doAllSupplier()
{
    if(document.getElementById('ctl00_MainContent_RbAllSupplier').checked=true)
    {
    document.getElementById('ctl00_MainContent_DDLSupplierName').value="00000000-0000-0000-0000-000000000000";        
    //document.getElementById('ctl00_MainContent_RbSpecificSupplier').checked=false;
    document.getElementById('childTblSpecificSupplier').style['display']='none';
    }
}
//For Specific Category
function doSpecificCategory()
{
    if(document.getElementById('ctl00_MainContent_RbSpecificCategory').checked=true)
    {
    
    //document.getElementById('ctl00_MainContent_RbAllCategory').checked=false;
    document.getElementById('tdCategory').style['display']='';
    }
}
// For All Category
function doAllCategory()
{
    if(document.getElementById('ctl00_MainContent_RbAllCategory').checked=true)
    {
    document.getElementById('ctl00_MainContent_DDLCategory').value="00000000-0000-0000-0000-000000000000";
    //document.getElementById('ctl00_MainContent_RbSpecificCategory').checked=false;
    document.getElementById('tdCategory').style['display']='none';
    }
}
//For All Sub Category
function doAllSubCategory()
{
    if(document.getElementById('ctl00_MainContent_RbAllSubCategory').checked=true)
    {
    document.getElementById('ctl00_MainContent_DDLSubCategory').value="00000000-0000-0000-0000-000000000000";    
    //document.getElementById('ctl00_MainContent_RbSpecificSubCategory').checked=false;
    document.getElementById('tdSubCategory').style['display']='none';
    }
}
//For Specific Sub Category
function doSpecificSubCategory()
{
    if(document.getElementById('ctl00_MainContent_RbSpecificSubCategory').checked=true)
    {
    //document.getElementById('ctl00_MainContent_RbAllSubCategory').checked=false;
    document.getElementById('tdSubCategory').style['display']='';
    }
}
function doSpecificBrand()
{
    if(document.getElementById('ctl00_MainContent_RbSpecificBrand').checked=true)
    {
    
    //document.getElementById('ctl00_MainContent_RbAllBrand').checked=false;
    document.getElementById('tdBrand').style['display']='';
    }
}

function doAllBrand()
{
    if(document.getElementById('ctl00_MainContent_RbAllBrand').checked=true)
    {
    document.getElementById('ctl00_MainContent_DDLBrand').value="00000000-0000-0000-0000-000000000000";    
    //document.getElementById('ctl00_MainContent_RbSpecificBrand').checked=false;
    document.getElementById('tdBrand').style['display']='none';
    }
}

//For Formating From Date Field
function formatFromDateField(){
    var value=document.getElementById("ctl00_MainContent_txtFromDate").value;
    if(value.length==2){
      document.getElementById("ctl00_MainContent_txtFromDate").value=document.getElementById("ctl00_MainContent_txtFromDate").value+"/";
    } else if(value.length==5){
      document.getElementById("ctl00_MainContent_txtFromDate").value=document.getElementById("ctl00_MainContent_txtFromDate").value+"/20";
    }
}
//For Formating To Date Field
function formatToDateField(){
    var value=document.getElementById("ctl00_MainContent_txtToDate").value;
    if(value.length==2){
      document.getElementById("ctl00_MainContent_txtToDate").value=document.getElementById("ctl00_MainContent_txtToDate").value+"/";
    } else if(value.length==5){
      document.getElementById("ctl00_MainContent_txtToDate").value=document.getElementById("ctl00_MainContent_txtToDate").value+"/20";
    }
}
//Focus Control By Enter Key
function FocusControl_byEnter()
{
    if(event.keyCode==13)
    {
        if (document.activeElement.id =="ctl00_MainContent_txtFromDate")
        {
           document.getElementById("ctl00_MainContent_txtToDate").focus();
        }
        else if (document.activeElement.id =="ctl00_MainContent_txtToDate")
        {
           document.getElementById("ctl00_MainContent_btnReport").focus();
        }

    }
}    

</script>


<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr>
    	<td align="left" valign="top" style="height:60px; text-align: center; background-color: #99cccc;">
            <span style="font-size: 24pt">
            Purchase Register</span></td>
	</tr>
	<tr>
    	<td align="left" valign="top">
			<table width="100%" style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid">
        		<tr>
          			<td width="5%">&nbsp;</td>
          			<td>
						<table width="100%" border="0" cellspacing="0" cellpadding="0">
              				<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Date &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                        <asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label></span></strong></td>
              				</tr>


              				<tr> 
                				<td style="height: auto" >
                				
                				<table id="TblDemandDate" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td style="text-align: right; width: 50%; vertical-align: middle;">&nbsp;From &nbsp;
                                                  <asp:TextBox ID="txtFromDate" runat="server" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox><img id="imgFromDate"
                                                      alt="Pick Date" src="../../Images/calendar.gif" style="width: 37px; height: 20px;" />
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFromDate"
                                                      ErrorMessage="*" SetFocusOnError="True" ToolTip="Date Field can't be blank!" ValidationGroup="GroupPurchaseReport"></asp:RequiredFieldValidator>
                                                  <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtFromDate"
                                                      ErrorMessage="*" MaximumValue="01/01/2999" MinimumValue="01/01/1973" SetFocusOnError="True"
                                                      ToolTip="Please enter a valid date." Type="Date" ValidationGroup="GroupPurchaseReport"></asp:RangeValidator>
                                                      <script language="javascript" type="text/javascript" >
//                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
//                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
//                              
//                              function pageLoadedHandler(sender, args) 
//                                { SetMyCalendar(); }
//                              function EndRequestHandler(sender, args) 
//                                { SetMyCalendar();}
//                              function SetMyCalendar() 
//                              {
                                if (document.getElementById("ctl00_MainContent_txtFromDate"))
                                {
                                    Calendar.setup(
                                    {
                                        inputField  : "ctl00_MainContent_txtFromDate",      
                                        ifFormat    : "mm/dd/y",    
                                        button      : "imgFromDate",   
                                        weekNumbers : false
                                    }
                                    );    
                                }   
                              // }	
</script></td>
                      						<td width="50%" style="vertical-align: middle">
                                                  To &nbsp; &nbsp;<asp:TextBox ID="txtToDate" runat="server" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox><img alt="Pick Date" id="imgToDate" src="../../Images/calendar.gif" style="width: 37px; height: 20px;" />
                        <asp:RequiredFieldValidator
                                                      ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtToDate" ErrorMessage="*"
                                                      SetFocusOnError="True" ToolTip="Date Field can't be blank!" ValidationGroup="GroupPurchaseReport"></asp:RequiredFieldValidator>
                                                  <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtToDate"
                                                      ErrorMessage="*" MaximumValue="01/01/2999" MinimumValue="01/01/1973" SetFocusOnError="True"
                                                      ToolTip="Please enter a valid date." Type="Date" ValidationGroup="GroupPurchaseReport"></asp:RangeValidator>
                                                  <asp:CompareValidator
                                                          ID="CompareValidator1" runat="server" ControlToCompare="txtFromDate" ControlToValidate="txtToDate"
                                                          ErrorMessage="*" Operator="GreaterThanEqual" SetFocusOnError="True" ToolTip="End date can't be less than start date!"
                                                          Type="Date" ValidationGroup="GroupPurchaseReport"></asp:CompareValidator>
                        <script language="javascript" type="text/javascript">
                            if (document.getElementById("ctl00_MainContent_txtToDate"))
                                {
                                   Calendar.setup(
                                    {
                                        inputField  : "ctl00_MainContent_txtToDate",      
                                        ifFormat    : "mm/dd/y",    
                                        button      : "imgToDate",   
                                        weekNumbers : false
                                    }
                                    );    
                                }   
                          </script>
                                                  </td>
                    					</tr>
                  					</table>
                				</td>
              				</tr>
              				<tr> 
                				<td align="left" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Report</span></strong></td>
              				</tr>
              				
              				<tr> 
                				<td align="left" valign="top">
                				<table id="TblDemandReport" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td>
                				    <table id="Table1" width="100%" border="0">
                    					<tr>
                      						<td><asp:RadioButton ID="RbSupplierWisePurchase" runat="server" GroupName="DemandReport" Enabled="False" Visible="False" />
                                                  <asp:Label ID="lblSupplierWisePurchase" runat="server" Text="Supplier wise Purchase " Enabled="False" Visible="False"></asp:Label></td>
                    					</tr>
                    					<tr>
                      						<td><asp:RadioButton ID="RbSWPSummary" runat="server" GroupName="DemandReport" Enabled="False" Visible="False" />
                                                  <asp:Label ID="lblSupplierWisePurchaseSummary" runat="server" Text="Supplier wise Purchase (Summary)" Enabled="False" Visible="False"></asp:Label></td>
                    					</tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbProductWisePurchase" runat="server" GroupName="DemandReport" Enabled="False" Visible="False" />
                                                <asp:Label ID="lblProductwisePurchase" runat="server" Text="Product wise Purchase" Enabled="False" Visible="False"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbProductWiseDetails" runat="server" GroupName="DemandReport" />
                                                <asp:Label ID="lblProductWisePurchaseDatails" runat="server" Text="Product Wise Purchase Details"></asp:Label></td>
                                        </tr>
                    					<tr>
                      						<td><asp:RadioButton ID="RbDailyPurchaseRegister" runat="server" GroupName="DemandReport" Checked="True" />
                                                  <asp:Label ID="lblDailyPurchase" runat="server" Text="Daily Purchase Register"></asp:Label></td>
                    					</tr>
                  					</table>

                      						</td>
                    					</tr>
                  					</table>
                				</td>
              				</tr>
              				<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Supplier</span></strong></td>
              				</tr>
              				
                            <tr>
                                <td align="left" valign="top">
                                <table id="TblDemandSupplier" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td style="width: 30%"><asp:RadioButton ID="RbAllSupplier" runat="server" Text="All Supplier" Checked="True" GroupName="Supplier" /></td>
                      						<td width="70%">&nbsp;</td>
                    					</tr>
                    					<tr>
                      						<td style="width: 30%">
                      						<asp:RadioButton ID="RbSpecificSupplier" runat="server" Text="Specific Supplier" GroupName="Supplier" /></td>
                      						<td  id="childtblSpecificSupplier" style="width:90%;display:none">
                                                <asp:DropDownList ID="DDLSupplierName" runat="server" BackColor="#E0E0E0" Width="211px">
                                                </asp:DropDownList>                      						
                      						</td>
                    					</tr>
                    					
                  					</table>
                                </td>
                            </tr>
              				<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Category</span></strong></td>
              				</tr>
                            
                            <tr>
                                <td align="left" valign="top">
                                    <table id="TblDemandCategory" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td width="30%"><asp:RadioButton ID="RbAllCategory" runat="server" Text="All Category" Checked="True" GroupName="Category" /></td>
                      						<td width="70%">&nbsp;</td>
                    					</tr>
                                        <tr>
                                            <td width="30%">
                                                <asp:RadioButton ID="RbSpecificCategory" runat="server" Text="Specific Category" GroupName="Category" /></td>
                                            <td  id="tdCategory" style="width:70%;display:none">
                                                <asp:DropDownList ID="DDLCategory" runat="server" BackColor="#E0E0E0" Width="211px" AutoPostBack="false">
                                                </asp:DropDownList></td>
                                        </tr>
                                        
                  					</table>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="height: 25px" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Sub Category</span></strong></td>
                            </tr>
                            <tr>
                                <td align="left" style="height: 25px" valign="bottom">
                        <table id="TblDemandSubCategory" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td width="30%"><asp:RadioButton ID="RbAllSubCategory" runat="server" Text="All Sub Category" Checked="True" GroupName="SubCategory" /></td>
                      						<td width="70%">&nbsp;</td>
                    					</tr>
                                        <tr>
                                            <td width="30%">
                                                <asp:RadioButton ID="RbSpecificSubCategory" runat="server" Text="Specific Sub Category" GroupName="SubCategory" /></td>
                                            <td  id="tdSubCategory" style="width:70%;display:none">
                                                <asp:DropDownList ID="DDLSubCategory" runat="server" BackColor="#E0E0E0" Width="211px">
                                                </asp:DropDownList></td>
                                        </tr>
                                        
                  					</table>                  		
                                </td>
                            </tr>
                            
              				<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Brand</span></strong></td>
              				</tr>
                            
                                <tr>
                                <td align="left" valign="top">
                                    <table id="TblDemandBrand" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td width="30%"><asp:RadioButton ID="RbAllBrand" runat="server" Text="All Brand" Checked="True" GroupName="Brand" /></td>
                      						<td width="70%">&nbsp;</td>
                    					</tr>
                                        <tr>
                                            <td width="30%">
                                                <asp:RadioButton ID="RbSpecificBrand" runat="server" Text="Specific Brand" GroupName="Brand" /></td>

                                            <td  id="tdBrand" style="width:70%;display:none">
                                                <asp:DropDownList ID="DDLBrand" runat="server" BackColor="#E0E0E0" Width="211px">
                                                </asp:DropDownList></td>

                                        </tr>
                  			        </table>
                  			 
                  			 <table id="tblReportButton" width="100%" border="0" >
                    					<tr>
                      						<td width="15%">
                                                  <asp:Button ID="btnReport" runat="server" Text="Report" Width="95px" BackColor="#00C0C0" UseSubmitBehavior="False" OnClick="btnReport_Click"  /></td>
                      						<td width="15%">
                                                  <asp:Button ID="btnClose" runat="server" Text="Close" Width="103px" BackColor="#00C0C0" UseSubmitBehavior="False" OnClick="btnClose_Click" ValidationGroup="CloseGroup" /></td>
                      						<td width="70%"></td>
                    					</tr>
                                        
                  			        </table>
                  			        
                  			    </td>
                            </tr>                            
						</table>
					</td>
          <td style="width: 7%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top">&nbsp;</td>
  </tr>
</table>


</asp:Content>

