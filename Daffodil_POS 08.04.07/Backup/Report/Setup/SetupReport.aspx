<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SetupReport.aspx.cs" Inherits="Report_Setup_SetupReport" Title="::.. Setup Report Pages ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


<script language="javascript" type="text/javascript">
//for enable disable texbox and drop down list
//function doSpecificBranch()
//{
//    if(document.getElementById('ctl00_MainContent_RbSpecificBranch').checked=true)
//    {
//    
//    document.getElementById('ctl00_MainContent_RbAllBranch').checked=false;
//    document.getElementById('childTblSpecificBranch').style['display']='';
//    }
//}

//function doAllBranch()
//{
//    if(document.getElementById('ctl00_MainContent_RbAllBranch').checked=true)
//    {
//    
//    document.getElementById('ctl00_MainContent_RbSpecificBranch').checked=false;
//    document.getElementById('childTblSpecificBranch').style['display']='none';
//    }
//}
</script>


<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr>
    	<td align="left" valign="top" style="height:60px; text-align: center; background-color: #99cccc;">
            <span style="font-size: 24pt">Setup Information</span></td>
	</tr>
	<tr>
    	<td align="left" valign="top">
			<table width="100%" style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid">
        		<tr>
          			<td width="5%">&nbsp;</td>
          			<td>
						<table width="100%" border="0" cellspacing="0" cellpadding="0">

              				<!--<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Branch &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                        <asp:Label ID="lblmsg" runat="server" style="font-weight: bold; color: #ff0066"></asp:Label></span></strong></td>
              				</tr>

              				<tr> 
                				<td align="left" valign="top">
                				<table id="TblDemandBranch" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; height: 57px;">
                    					<tr>
                      						<td style="width: 30%"><asp:RadioButton ID="RbAllBranch" runat="server" Text="All Branch" Checked="True" /></td>
                      						<td width="70%"></td>
                    					</tr>
                    					<tr>
                      						<td style="width: 30%; text-align: left;">
                      						<asp:RadioButton ID="RbSpecificBranch"  runat="server" Text="Specific Branch" Checked="false" />
                                                  </td>
                      						<td id="childTblSpecificBranch" style="width: 70%;display:none">
                                            <asp:TextBox ID="txtBranchCode" runat="server" Width="171px"></asp:TextBox>
                      						<asp:TextBox ID="txtBranchName" runat="server" BackColor="#E0E0E0" Width="238px"></asp:TextBox>
                      						</td>
                    					</tr>
                    					
                  					</table>
                				</td>
              				</tr>-->
              				<tr> 
                				<td align="left" style="height:25px;" valign="bottom">
                                    <strong><span style="color: #0000ff">Demand Setup Report</span></strong></td>
              				</tr>
              				
              				<tr> 
                				<td align="left" valign="top">
                				<table id="TblDemandReport" width="100%" border="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                    					<tr>
                      						<td>
                				    <table id="Table1" width="100%" border="0">
                    					<tr>
                      						<td><asp:RadioButton ID="RbBranchInformation" runat="server" Text="Branch Information" GroupName="Setup" Checked="True" /></td>
                    					</tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbMemberInformation" runat="server" Text="Member Information" GroupName="Setup" /></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbSupplierInformation" runat="server" Text="Supplier Information" GroupName="Setup" /></td>
                                        </tr>
                    					<tr>
                      						<td><asp:RadioButton ID="RbProductInformation" runat="server" Text="Product Information" GroupName="Setup" /></td>
                    					</tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbProductCategoryInfo" runat="server" Text="Product Category Information" GroupName="Setup" /></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbProductSubCategoryInfo" runat="server" Text="Product Sub Category Information" GroupName="Setup" /></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbProductUnitInfo" runat="server" Text="Product Unit Information" GroupName="Setup"/></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbBoothInfo" runat="server" Text="Booth Information" GroupName="Setup" /></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RbProductSummary" runat="server" Text="Product Summary" GroupName="Setup" /></td>
                                        </tr>
                  					</table>

                      						</td>
                    					</tr>
                  					</table>
                				</td>
              				</tr>
                            
                                <tr>
                                <td align="left" valign="top">
                  			 
                  			 <table id="tblReportButton" width="100%" border="0" >
                    					<tr>
                      						<td style="width: 15%">
                                                  <asp:Button ID="btnReport" runat="server" Text="Report" Width="95px" BackColor="#00C0C0" UseSubmitBehavior="False" OnClick="btnReport_Click" /></td>
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

