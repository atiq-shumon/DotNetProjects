<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" autoeventwireup="true" inherits="SalesReturn, App_Web_jxa7k8pl" masterpagefile="~/MasterPage.master" title=" Sales Retrun Information" %>

<script runat="server">

    
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<script language ="javascript" type="text/javascript">

//Call on txtDiscountTotal Field
function CalculatePaidAmount()
{
    var vTotalAmount=document.getElementById('txtTotalAmount').value;
    var vDiscountTotal=document.getElementById('txtDiscountTotal').value;
    var vPaidAmount=vTotalAmount-vDiscountTotal;
    document.getElementById('PaidAmount').value=vPaidAmount;
}

//Call on PaymentAmount Field
function CalculateRetrunDue()
{
    var vPaidAmount=document.getElementById('PaidAmount').value;
    var vPaymentAmount=document.getElementById('txtPA').value;

if (vPaymentAmount>vPaidAmount){
    var vReturnAmount=vPaymentAmount-vPaidAmount;
    document.getElementById('txtReturnAmount').value=vReturnAmount;
    document.getElementById('txtDue').value=0;
    }
else if (vPaymentAmount==vPaidAmount){
    document.getElementById('txtReturnAmount').value=0;
    document.getElementById('txtDue').value=0;
    }
else if (vPaymentAmount<vPaidAmount){
    var vDueAmount=vPaymentAmount-vPaidAmount;
    document.getElementById('txtReturnAmount').value=0;
    document.getElementById('txtDue').value=vDueAmount;
    }
}


</script>
<div id="masterDiv" class="DPOSStyleSheet">

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top" style="width: 765px">&nbsp;
        </td>
  </tr>
  <tr>
    <td align="left" valign="top" style="width: 765px"><table width="100%">
        <tr>
          <td width="5%">&nbsp;</td>
          <td><table width="100%" border="0" cellspacing="0" cellpadding="0">

              <tr> 
                <td align="left" valign="top" style="height: 17px"><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label>
                    <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></td>
              </tr>

              <tr> 
                <td align="left" valign="top" style="height:auto;"><table width="100%">

					<tr> 
                      <td style="width: 17%;"> <asp:Label ID="InvoiceNo"  text="Invoice No" runat="server"></asp:Label></td>
                      <td style="width: 222px;"> 
                        <asp:TextBox ID="txtInvoiceNo" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px" style="vertical-align: top" OnTextChanged="txtInvoiceNo_TextChanged"></asp:TextBox><asp:Button ID="btnInvoiceNo" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" /></td>
                        
                        
                        <td style="width: 13%;">
                            &nbsp;<asp:Label ID="Date"  text="Date" runat="server"></asp:Label></td>
                        <td style="vertical-align: top;">
                            <asp:TextBox ID="txtDate" runat="server" Width="184px" BorderStyle="Solid" BorderWidth="1px" style="vertical-align: top" BackColor="Info"></asp:TextBox>
                            <!-- <img id="imgSalesDate" alt="Pick Date" src="../../Images/calendar.gif" style="width: 42px; height: 20px" hidefocus="hideFocus" />
                            <script language="javascript" type="text/javascript">
                            if ( document.getElementById("ctl00_MainContent_txtDate") )
                            {
                                Calendar.setup(
                                {
                                    inputField  : "ctl00_MainContent_txtDate",      
                                    ifFormat    : "dd/mm/y",    
                                    button      : "imgSalesDate",   
                                    weekNumbers : false
                                }
                                );    
                            }   	    
                        </script>--> 
                            </td>
                    </tr>
                  </table></td>
              </tr>
              <tr>
                <td align="left" valign="top"><table width="100%">
					<tr> 
                      <td style="width: 17%"> <asp:Label ID="CustomerId"  text="Member ID" runat="server"></asp:Label></td>
                      <td style="width: 222px "> 
                        <asp:TextBox ID="txtCustomerId" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px" style="vertical-align: top" OnTextChanged="txtCustomerId_TextChanged" BackColor="Info" ValidationGroup="MemberGroupValidation"></asp:TextBox><asp:Button ID="btnCustomerId" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" ValidationGroup="MemberGroupValidation" /></td>
                      <td style="width: 11%"> </td>
                      <td>&nbsp; </td>
                    </tr>

                  </table></td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="height:auto; ">
                   <asp:Panel id="pnlMember" runat="server" Height="80px" Width="597px" Visible="False">
                    <table id="tblMem" style="WIDTH: 117%">
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="CustomerName"  text="Member Name" runat="server"></asp:Label></td>
                      <td colspan="3"><asp:TextBox ID="txtCustomerName" runat="server" Width="503px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ReadOnly="True" ValidationGroup="MemberGroupValidation"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="Address"  text="Address" runat="server"></asp:Label></td>
                      <td colspan="3"><asp:TextBox ID="txtAddress" runat="server" Width="503px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ReadOnly="True" ValidationGroup="MemberGroupValidation"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="DepositBalance"  text="Deposit Balance" runat="server"></asp:Label></td>
                      <td colspan="3"><asp:TextBox ID="txtDepositBalance" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ReadOnly="True" ValidationGroup="MemberGroupValidation"></asp:TextBox> 
                      </td>
                    </tr>
                    </table>
                    
                </asp:Panel></td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%">
                    <tr> 
                    <tr> 
                      <td style="width: 116px"> <asp:Label ID="Product"  text="Product Code" runat="server"></asp:Label></td>
                      <td colspan="3" style="vertical-align: top"> <asp:TextBox ID="txtProduct" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px" OnTextChanged="txtProduct_TextChanged" style="vertical-align: top" ValidationGroup="ProductGroupValidation"></asp:TextBox><!--<asp:Button ID="Button1" runat="server" Text="..." Font-Bold="True" Height="21px" Width="30px" />-->
                          <asp:Button ID="btnProducId" runat="server" Text="..." Height="22px" Width="30px" Font-Bold="True" ValidationGroup="ProductGroupValidation" /></td>
                    </tr>
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="ProductName"  text="Product Name" runat="server"></asp:Label></td>
                      <td colspan="3"> <asp:TextBox ID="txtProductName" runat="server" Width="505px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ValidationGroup="ProductGroupValidation"></asp:TextBox>
                      </td>
                    </tr>
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="Rate"  text="Rate" runat="server"></asp:Label></td>
                      <td style="width: 220px"><asp:TextBox ID="txtRate" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ValidationGroup="ProductGroupValidation"></asp:TextBox></td>
                      <td style="width: 94px"><asp:Label ID="Vat"  text="Vat" runat="server"></asp:Label></td>
                      <td> <asp:TextBox ID="txtVat" runat="server" Width="184px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ValidationGroup="ProductGroupValidation"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td style="vertical-align: top; width: 116px;"><asp:Label ID="Discount" runat="server" Text="Discount" style="vertical-align: top"></asp:Label></td>
                      <td style="width: 220px"> <asp:TextBox ID="txtDiscount" runat="server" BorderStyle="Solid" BorderWidth="1px"
                              Style="vertical-align: top" Width="180px" BackColor="Info" ValidationGroup="ProductGroupValidation"></asp:TextBox> 
                        &nbsp;</td>
                      <td style="vertical-align: top; width: 94px;">&nbsp; <asp:Label ID="Tax"  text="Tax" runat="server"></asp:Label></td>
                      <td style="vertical-align: top"> <asp:TextBox ID="txtTax" runat="server" Width="184px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ValidationGroup="ProductGroupValidation"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td style="vertical-align: top; width: 116px;"> <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label></td>
                      <td style="width: 220px"> <asp:TextBox ID="txtQuantity" runat="server" BorderStyle="Solid" BorderWidth="1px"
                              Style="vertical-align: top" Width="180px" ValidationGroup="ProductGroupValidation"></asp:TextBox> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtQuantity"
                              Display="Dynamic" ErrorMessage="Enter a valid number." Font-Bold="True" SetFocusOnError="True"
                              ToolTip="Enter a valid number." ValidationExpression="\d+[.]?[\d]{0,4}" ValidationGroup="ProductGroupValidation">*</asp:RegularExpressionValidator>&nbsp;</td>
                      <td style="width: 94px; vertical-align: top;">&nbsp; <asp:Button ID="btnAdd" runat="server"  Text="Add" Width="60px" OnClick="btnAdd_Click" style="vertical-align: top" ValidationGroup="ProductGroupValidation"/></td>
                      <td> </td>
                    </tr>
                  </table>
                    &nbsp;&nbsp;</td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="height: auto ;"> &nbsp;<asp:GridView id="GridView1" runat="server" AutoGenerateColumns="False" 
                OnRowCommand="GridView1_RowEdting" 
                OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="PK" OnRowEditing="GridView1_RowEditing">
                        <columns>
<asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
<asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
<asp:BoundField DataField="Product Code" SortExpression="Product Code" HeaderText="Product Code"></asp:BoundField>
<asp:BoundField DataField="Product Name" SortExpression="Product Name" HeaderText="Product Name"></asp:BoundField>
<asp:BoundField DataField="Quantity" SortExpression="Quantity" HeaderText="Quantity"></asp:BoundField>
<asp:BoundField DataField="Rate" SortExpression="Rate" HeaderText="Rate"></asp:BoundField>
<asp:BoundField DataField="VAT" SortExpression="VAT" HeaderText="VAT"></asp:BoundField>
<asp:BoundField DataField="TAX" SortExpression="TAX" HeaderText="TAX"></asp:BoundField>
<asp:BoundField DataField="Discount" SortExpression="Discount" HeaderText="Discount"></asp:BoundField>
<asp:BoundField DataField="Total Amount" SortExpression="Total Amount" HeaderText="Total Amount"></asp:BoundField>
</columns>
                    </asp:GridView>&nbsp;&nbsp;</td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%">
                    <tr> 
                      <td width="15%"  align="right" valign="top"></td>
                      <td width="25%"  align="right" valign="top"></td>
                      <td width="25%" align="right" valign="top"><asp:Label ID="TotalProduct" runat="server" Text="Total Amount"></asp:Label></td>
                      <td width="35%" align="left" valign="top"><asp:TextBox ID="txtTotalAmount" value="" runat="server" BackColor="Info" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td>&nbsp;</td>
                      <td></td>
                      <td  align="right" valign="top"><asp:Label ID="Label1"  text="Discount" runat="server"></asp:Label></td>
                      <td> <asp:TextBox ID="txtDiscountTotal"  value="" runat="server" BorderStyle="Solid" BorderWidth="1px"  ValidationGroup="SalesGroupTextField"></asp:TextBox> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtDiscountTotal"
                              Display="Dynamic" ErrorMessage="You must enter a valid price." Font-Bold="True"
                              SetFocusOnError="True" ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}" ValidationGroup="SalesGroupTextField">*</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr> 
                      <td>&nbsp;</td>
                      <td>&nbsp;</td>
                      <td align="right" valign="top"><asp:Label ID="PaymentMode"  text="Payment Mode" runat="server"></asp:Label></td>
                      <td> <asp:DropDownList ID="ddlPaymentMode" runat="server" Width="156px" ValidationGroup="SalesGroupTextField"> 
                        </asp:DropDownList> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlPaymentMode"
                              ErrorMessage="Select a payment mode!" SetFocusOnError="True" ValidationGroup="SalesGroupTextField">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr> 
                      <td style="height: 24px"> </td>
                      <td style="height: 24px"> </td>
                      <td align="right" valign="top" style="height: 24px"> <asp:Label ID="Label3" runat="server" Text="Payment Amount"></asp:Label></td>
                      <td style="height: 24px"> <asp:TextBox ID="txtPaymentAmount" runat="server" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td> </td>
                      <td> </td>
                      <td align="right" valign="top"> <asp:Label ID="PaidAmount" value="" text="Paid Amount" runat="server"></asp:Label></td>
                      <td> <asp:TextBox ID="txtPaidAmount" runat="server" BackColor="Info" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td> </td>
                      <td> </td>
                      <td align="right" valign="top"> <asp:Label ID="Label4" runat="server" Text="Return Amount"></asp:Label></td>
                      <td> <asp:TextBox ID="txtReturnAmount" runat="server" BackColor="Info" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td>&nbsp;</td>
                      <td>&nbsp;</td>
                      <td align="right" valign="top"><asp:Label ID="Due"  text="Due Amount" runat="server"></asp:Label></td>
                      <td> <asp:TextBox ID="txtDue" runat="server" BorderStyle="Solid" BorderWidth="1px" ReadOnly="True" ValidationGroup="SalesGroupTextField"></asp:TextBox></td>
                    </tr>
                  </table></td>
              </tr>
              <tr> 
                <td align="left" valign="top"><table width="100%">
                    <tr> 
                      <td width="10%"><asp:Button ID="btnNew" runat="server"  Text="New" Width="60px"/></td>
                      <td width="10%"><asp:Button ID="btnSave" runat="server"  Text="Save" Width="60px" ValidationGroup="SalesGroupTextField" OnClick="btnSave_Click"/></td>
                      <td>&nbsp;</td>
                      <td>&nbsp;</td>
                    </tr>
                  </table></td>
              </tr>
            </table>
              <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="SalesGroupTextField" />
              <asp:HiddenField ID="HiddenField1" runat="server" />
                  <asp:HiddenField
                                  id="hfP_PK" runat="server"></asp:HiddenField>
              <asp:HiddenField id="hfMemberPK" runat="server"></asp:HiddenField>
          </td>
          <td width="2%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top" style="width: 765px">&nbsp;
        </td>
  </tr>
</table>
</div> 
</asp:Content>
