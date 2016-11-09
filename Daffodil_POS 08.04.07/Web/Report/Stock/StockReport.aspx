<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StockReport.aspx.cs" Inherits="Report_Stock_StockReport" Title="::.. Stock Report ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<SCRIPT language="JavaScript" src="../../JavaScript/calendar.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../JavaScript/calendar-en.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../JavaScript/calendar-setup.js"></SCRIPT>

<link href="../../JavaScript/calendar-system.css" rel="stylesheet" type="text/css" />
<script language="javascript" type="text/javascript">
//For Specific Branch
//function doSpecificBranch()
//{
//    if(document.getElementById('ctl00_MainContent_RbSpecificBranch').checked=true)
//    {
//    
//    document.getElementById('ctl00_MainContent_RbAllBranch').checked=false;
//    document.getElementById('childTblSpecificBranch').style['display']='';
//    }
//}

//For All Branch
//function doAllBranch()
//{
//    if(document.getElementById('ctl00_MainContent_RbAllBranch').checked=true)
//    {
//    
//    document.getElementById('ctl00_MainContent_RbSpecificBranch').checked=false;
//    document.getElementById('childTblSpecificBranch').style['display']='none';
//    }
//}

//For Specific Product
function doSpecificProduct()
{
    if(document.getElementById('ctl00_MainContent_RbSpecificProduct').checked=true)
    {
    document.getElementById('ctl00_MainContent_RbAllProduct').checked=false;
    document.getElementById('tdSpecificProduct').style['display']='';
    }

}

//For All Product
function doAllProduct()
{
    if(document.getElementById('ctl00_MainContent_RbAllProduct').checked=true)
    {
    document.getElementById('ctl00_MainContent_DDLProductName').value="00000000-0000-0000-0000-000000000000";
    document.getElementById('ctl00_MainContent_RbSpecificProduct').checked=false;
    document.getElementById('tdSpecificProduct').style['display']='none';
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

//For Specific Brand
function doSpecificBrand()
{
    if(document.getElementById('ctl00_MainContent_RbSpecificBrand').checked=true)
    {
    
    //document.getElementById('ctl00_MainContent_RbAllBrand').checked=false;
    document.getElementById('tdBrand').style['display']='';
    }
}
//For All Brand
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
            <span style="font-size: 24pt">Stock Register</span></td>
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
                                    <strong><span style="color: #0000ff">Demand Date<asp:Label ID="lblErrorMessage" runat="server"
                                        CssClass="errormsg" Style="position: relative"></asp:Label></span></strong></td>
              				</tr>


              				<tr> 
                				<td align="left" valign="top">
                				
                				<table id="TblDemandDate" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td style="text-align: right; width: 50%;">From &nbsp;
                                                  <asp:TextBox ID="txtFromDate" runat="server" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox>
                                                  <img id="imgFromDate" alt="Pick Date" src="../../Images/calendar.gif" style="width: 37px" />
<script language="javascript" type="text/javascript">
//                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
//                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
//                              
//                              function pageLoadedHandler(sender, args) 
//                                { SetMyCalendar(); }
//                              function EndRequestHandler(sender, args) 
//                                { SetMyCalendar();}
//                              function SetMyCalendar() 
//                              {
                                if (document.getElementById("ctl00_MainContent_txtFromDate") )
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
</script>                                                      
                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFromDate"
                                                      ErrorMessage="*" SetFocusOnError="True" ToolTip="Date Field can't be blank!" ValidationGroup="GroupStockRegister"></asp:RequiredFieldValidator>
                                                  <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFromDate"
                                                      ErrorMessage="*" MaximumValue="01/01/2999" MinimumValue="01/01/1973" SetFocusOnError="True"
                                                      ToolTip="Please enter a valid date." Type="Date" ValidationGroup="GroupStockRegister"></asp:RangeValidator>&nbsp;</td>
                      						<td width="50%">
                                                  To &nbsp; &nbsp;<asp:TextBox ID="txtToDate" runat="server" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox><img
                                                      id="imgToDate" alt="Pick Date" src="../../Images/calendar.gif" style="width: 37px" />
<script language="javascript" type="text/javascript">
//                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
//                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
//                              
//                              function pageLoadedHandler(sender, args) 
//                                { SetMyCalendar(); }
//                              function EndRequestHandler(sender, args) 
//                                { SetMyCalendar();}
//                              function SetMyCalendar() 
//                              {
                                if (document.getElementById("ctl00_MainContent_txtToDate") )
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
                              // }	
</script>                                                      
                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtToDate"
                                                      ErrorMessage="*" SetFocusOnError="True" ToolTip="Date Field can't be blank!" ValidationGroup="GroupStockRegister"></asp:RequiredFieldValidator>
                                                  <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtToDate"
                                                      ErrorMessage="*" MaximumValue="01/01/2999" MinimumValue="01/01/1973" SetFocusOnError="True"
                                                      ToolTip="Please enter a valid date." Type="Date" ValidationGroup="GroupStockRegister"></asp:RangeValidator>
                                                  <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtFromDate"
                                                      ControlToValidate="txtToDate" ErrorMessage="*" Operator="GreaterThanEqual" SetFocusOnError="True"
                                                      ToolTip="End date can't be less than start date!" Type="Date" ValidationGroup="GroupStockRegister"></asp:CompareValidator></td>
                    					</tr>
                  					</table>
                				</td>
              				</tr>

              				<tr> 
                				<%--<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Branch</span></strong></td>--%>
              				</tr>

              				<tr> 
                				<td align="left" valign="top">
                                    <strong><span style="color: #0000ff">Demand Report</span></strong><%--				<table id="TblDemandBranch" width="100%" border="0" style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid; height: 57px;">
                    					<tr>
                      						<td style="width: 30%"><asp:RadioButton ID="RbAllBranch" runat="server" Text="All Branch" Checked="True" /></td>
                      						<td width="70%"></td>
                    					</tr>
                    					<tr>
                      						<td style="width: 30%; text-align: left;">
                      						<asp:RadioButton ID="RbSpecificBranch"  runat="server" Text="Specific Branch" Checked="false" />
                                                  </td>
                      						<td  id="childTblSpecificBranch" style="width: 70%;display:none" >
                      						<asp:TextBox ID="txtBranchCode" runat="server" Width="171px"></asp:TextBox>
                      						<asp:TextBox ID="txtBranchName" runat="server" BackColor="#E0E0E0" Width="238px"></asp:TextBox>
                      						
                      						</td>
                    					</tr>
                    					
                  					</table>--%></td>
              				</tr>
                            <tr>
                                <td align="left" valign="top">
                                    <table id="Table3" border="0" style="border-right: black 1px solid; border-top: black 1px solid;
                                        border-left: black 1px solid; border-bottom: black 1px solid" width="100%">
                                        <tr>
                                            <td>
                                                <table id="Table2" border="0" width="100%">
                                                    <tr>
                                                        <td>
                                                            &nbsp;<asp:RadioButton ID="rbWithAmount" runat="server" GroupName="DemandReport"/>
                                                            <asp:Label ID="lblWithAmount" runat="server" Text="Stock Register With Amount"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 30%">
                                                            &nbsp;<asp:RadioButton ID="rbWithoutAmount" runat="server" GroupName="DemandReport" Checked="true"/>
                                                            <asp:Label ID="lblWithoutAmount" runat="server" Text="Stock Register Without Amount"></asp:Label></td>
                                                        <td id="Td1" style="display: none; width: 70%">
                                                            <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#E0E0E0" Width="211px">
                                                            </asp:DropDownList></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
              				<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Product</span></strong></td>
              				</tr>
              				
              				<tr> 
                				<td align="left" valign="top" >
                				<table id="TblDemandReport" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td>
                				    <table id="Table1" width="100%" border="0">
                    					<tr>
                                            <td colspan="2">
                                                  <asp:RadioButton ID="RbAllProduct" runat="server" Checked="True" GroupName="DemandProduct" Text="All Product" />
                                                <asp:Label ID="lblAllProduct" runat="server" Text="All Product" Visible="False"></asp:Label></td>
                      						
                    					</tr>
                    					<tr>
                      						<td style="width:30%;"><asp:RadioButton ID="RbSpecificProduct" runat="server" GroupName="DemandProduct" Text="Specific Product" />
                                                  <asp:Label ID="lblSpecificProduct" runat="server" Text="Specific Product" Visible="False"></asp:Label></td>
                                            <td  id="tdSpecificProduct" style="width:70%;display:none">
                                                <asp:DropDownList ID="DDLProductName" runat="server" BackColor="#E0E0E0" Width="211px">
                                                </asp:DropDownList></td>
                      						
                    					</tr>
                  					</table>

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
                      						<td width="30%"><asp:RadioButton ID="RbAllCategory" runat="server" Text="All Category" Checked="True" GroupName="DemandCategory" /></td>
                      						<td width="70%">&nbsp;</td>
                    					</tr>
                                        <tr>
                                            <td width="30%">
                                                <asp:RadioButton ID="RbSpecificCategory" runat="server" Text="Specific Category" GroupName="DemandCategory" /></td>
                                            <td  id="tdCategory" style="width:70%;display:none">
                                                <asp:DropDownList ID="DDLCategory" runat="server" BackColor="#E0E0E0" Width="211px">
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
                      						<td width="30%"><asp:RadioButton ID="RbAllSubCategory" runat="server" Text="All Sub Category" GroupName="SubCategory" Checked="True" /></td>
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
                      						<td width="30%"><asp:RadioButton ID="RbAllBrand" runat="server" Text="All Brand" Checked="True" GroupName="DemandBrand" /></td>
                      						<td width="70%">&nbsp;</td>
                    					</tr>
                                        <tr>
                                            <td width="30%">
                                                <asp:RadioButton ID="RbSpecificBrand" runat="server" Text="Specific Brand" GroupName="DemandBrand" /></td>

                                            <td  id="tdBrand" style="width:70%;display:none">
                                                <asp:DropDownList ID="DDLBrand" runat="server" BackColor="#E0E0E0" Width="211px">
                                                </asp:DropDownList></td>

                                        </tr>
                  			        </table>
                  			 
                  			 <table id="tblReportButton" width="100%" border="0" >
                    					<tr>
                      						<td width="15%">
                                                  <asp:Button ID="btnReport" runat="server" Text="Report" Width="95px" BackColor="#00C0C0" UseSubmitBehavior="False" OnClick="btnReport_Click" ValidationGroup="GroupStockRegister" /></td>
                      						<td width="15%">
                                                  <asp:Button ID="btnClose" runat="server" Text="Close" Width="103px" BackColor="#00C0C0" UseSubmitBehavior="False" OnClick="btnClose_Click" /></td>
                      						<td width="70%"></td>
                    					</tr>
                                        
                  			        </table>
                  			        
                  			    </td>
                            </tr>                            
						</table>
					</td>
          <td width="7%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top">&nbsp;</td>
  </tr>
</table>

</asp:Content>

