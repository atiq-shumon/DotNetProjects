<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PurchaseReturn.aspx.cs" Inherits="Client_Purchase_PurchaseReturn" Title="::.. Purchase Return ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
  <asp:ScriptManager ID="ScriptManager1" runat="server">

    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<SCRIPT language="JavaScript" src="../../JavaScript/calendar.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../JavaScript/calendar-en.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../JavaScript/calendar-setup.js"></SCRIPT>
<DIV id="masterDiv" class="DPOSStyleSheet.css">
<SCRIPT language="javascript" type="text/javascript">

    function clickbtn(btnctrl)
	{
		if (event.keyCode==13)
		{
		    document.getElementById(btnctrl).click();						
		    return false;
		}
	}		


//for multiply unitprice and quentity
function  Product_Price()
{
var vQuentity=0;
var vUnitPrice=0;
var vDiscount=0;
vQuentity=document.getElementById("ctl00_MainContent_txtQuantity").value;
vUnitPrice=document.getElementById("ctl00_MainContent_txtUnitPrice").value;
vDiscount=document.getElementById("ctl00_MainContent_txtDiscoutInd").value;

    var vAmount=0;
    vAmount=((vUnitPrice - vDiscount) * vQuentity);
    document.getElementById("ctl00_MainContent_txtAmount").value=vAmount;

}

//Calculate NetPayable
function  CalculateNetPayable()
{
var vTotalAmount=0;
var vTotalDiscount=0;

if (document.getElementById("ctl00_MainContent_txtGroseTotal").value!="")
vTotalAmount=document.getElementById("ctl00_MainContent_txtGroseTotal").value;

if (document.getElementById("ctl00_MainContent_txtDeduction").value!="")
vTotalDiscount=document.getElementById("ctl00_MainContent_txtDeduction").value;
  var vNetPayable=0;
 vNetPayable=(parseFloat(vTotalAmount) - parseFloat(vTotalDiscount));
document.getElementById("ctl00_MainContent_txtReturnAmount").value=vNetPayable;
}


// For numeric field with float
//function doNumericWithFloat()
//{
//if(event.keyCode!=13 && event.keyCode<46||event.keyCode==47||event.keyCode>57)event.returnValue=false;
//}
// for numeric field
//function doNumeric()
//{
//if(event.keyCode!=13 && event.keyCode<48||event.keyCode>57)event.returnValue=false;
//}
//formating date field
	function formatDateField(){
		var value=document.getElementById("ctl00_MainContent_txtGRNDate").value;
		if(value.length==2){
		  document.getElementById("ctl00_MainContent_txtGRNDate").value=document.getElementById("ctl00_MainContent_txtDate").value+"/";
		} else if(value.length==5){
		  document.getElementById("ctl00_MainContent_txtGRNDate").value=document.getElementById("ctl00_MainContent_txtDate").value+"/20";
		}
	}	

function FocusControl_byEnter()
{
    if(event.keyCode==13)
         {
            
            if(document.activeElement.id=="ctl00_MainContent_txtRefno")
            {
                document.getElementById('ctl00_MainContent_ddlProductName').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtQuantity")
            {
                document.getElementById('ctl00_MainContent_txtRemarks').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtQuantity")
            {
                alert("Hi");
                document.getElementById('ctl00_MainContent_txtUnitPrice').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtUnitPrice")
            {
                document.getElementById('ctl00_MainContent_txtDiscoutInd').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtDiscoutInd")
            {
//                document.getElementById('ctl00_MainContent_txtAmount').focus();
//            }
//            else if(document.activeElement.id=="ctl00_MainContent_txtAmount")
//            {
                document.getElementById('ctl00_MainContent_txtRemarks').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtRemarks")
            {
                document.getElementById('ctl00_MainContent_btnAdd').focus();
            }
           else if(document.activeElement.id=="ctl00_MainContent_btnAdd")
            {
                document.getElementById('ctl00_MainContent_txtDeduction').focus();
            }
           else if(document.activeElement.id=="ctl00_MainContent_txtDeduction")
            {
                document.getElementById('ctl00_MainContent_btnSave').focus();
            }
        }
   else if(document.activeElement.id=="ctl00_MainContent_txtUnitPrice"
          ||document.activeElement.id=="ctl00_MainContent_txtDiscoutInd"
          ||document.activeElement.id=="ctl00_MainContent_txtAmount"
          ||document.activeElement.id=="ctl00_MainContent_txtDeduction")
        {
            if (event.keyCode<46||event.keyCode==47||event.keyCode>57)
            {
                event.returnValue=false;
            }
        }

    else if(document.activeElement.id=="ctl00_MainContent_txtQuantity")
        {
            if (event.keyCode<48||event.keyCode>57)
            {
                event.returnValue=false;
            }
        }
}
    
    
</SCRIPT>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 762px" vAlign=top align=left></TD></TR><TR><TD style="WIDTH: 762px" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="2%"></TD><TD style="WIDTH: 737px"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 799px"><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></TD></TR><TR><TD style="WIDTH: 799px"><TABLE width="100%"><TBODY><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 14%"><asp:Label id="GRNNo" runat="server" text="GRN No"></asp:Label></TD><TD style="VERTICAL-ALIGN: top; WIDTH: 31%" colSpan=2><asp:TextBox style="VERTICAL-ALIGN: top" id="txtGRNNo" runat="server" Width="188px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox> <asp:Button id="btnClickGRNNo" onclick="btnClickGRNNo_Click" runat="server" Width="1px" Height="1px" Text="." UseSubmitBehavior="False" __designer:wfdid="w9"></asp:Button></TD><TD colSpan=2><asp:Panel id="pnlPurchaseRDate" runat="server" Width="100%" __designer:wfdid="w3" Visible="False"><asp:Label id="Date" runat="server" text="GRN Date" __designer:wfdid="w1"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox style="VERTICAL-ALIGN: top" id="txtGRNDate" runat="server" Width="188px" BorderStyle="Solid" BorderWidth="1px" __designer:wfdid="w2" maxlength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox></asp:Panel></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="SupplierCode" runat="server" text="Supplier Name"></asp:Label></TD><TD style="WIDTH: 31%" colSpan=2><asp:DropDownList id="ddlSupplierCode" runat="server" Width="191px"></asp:DropDownList>&nbsp;<asp:Button id="btnSupplierCode" runat="server" Width="15px" Height="22px" Font-Bold="True" Text="..." UseSubmitBehavior="False" Visible="False" Enabled="False"></asp:Button> <asp:Button id="btnClickSupplierCode" onclick="btnClickSupplierCode_Click" runat="server" Width="1px" Height="10px" Text="." UseSubmitBehavior="False"></asp:Button></TD><TD style="WIDTH: 16%"></TD><TD style="WIDTH: 39%">&nbsp;</TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Address" runat="server" text="Address"></asp:Label></TD><TD style="WIDTH: 31%" colSpan=4><asp:TextBox id="txtSupplierAddress" runat="server" Width="532px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 14%"><asp:Label id="Refno" runat="server" text="Ref. No"></asp:Label></TD><TD style="VERTICAL-ALIGN: top; WIDTH: 31%" colSpan=2><asp:TextBox id="txtRefno" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="15"></asp:TextBox></TD><TD colSpan=3><asp:Panel id="pnlCurrentBalance" runat="server" Width="100%" __designer:wfdid="w8" Visible="False"><asp:Label id="CurrentBalance" runat="server" text="Current Balance" __designer:wfdid="w6"></asp:Label>&nbsp;&nbsp;&nbsp; <asp:TextBox id="txtCurrentBalance" runat="server" Width="192px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" __designer:wfdid="w7"></asp:TextBox></asp:Panel>&nbsp;
<SCRIPT language="javascript" type="text/javascript">
                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
                              
                              function pageLoadedHandler(sender, args) 
                                { SetMyCalendar(); }
                              function EndRequestHandler(sender, args) 
                                { SetMyCalendar();}
                              function SetMyCalendar() 
                              {
                                if (document.getElementById("ctl00_MainContent_txtDate") )
                                {
                                    Calendar.setup(
                                    {
                                        inputField  : "ctl00_MainContent_txtDate",      
                                        ifFormat    : "mm/dd/y",    
                                        button      : "imgPurchaseDate",   
                                        weekNumbers : false
                                    }
                                    );    
                                }   
                               }	
                        </SCRIPT>
 </TD></TR></TBODY></TABLE></TD></TR><TR><TD style="WIDTH: 799px; HEIGHT: 187px"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 14%"><asp:Label id="ProductName" runat="server" text="Product Name"></asp:Label></TD><TD style="WIDTH: 32%"><asp:DropDownList id="ddlProductName" runat="server" Width="188px">
                          </asp:DropDownList> <asp:Button id="btnClickPurductName" onclick="btnClickPurductName_Click" runat="server" Width="1px" Height="1px" Text="." UseSubmitBehavior="False"></asp:Button> <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ControlToValidate="ddlProductName" ErrorMessage="Select a product" ValidationGroup="ProductGroupTextField" SetFocusOnError="True">*</asp:RequiredFieldValidator></TD><TD style="WIDTH: 16%"></TD><TD style="WIDTH: 38%"></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Quantity" runat="server" text="Quantity"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtQuantity" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="5px" ControlToValidate="txtQuantity" ErrorMessage="Please enter  quantity, " ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ToolTip="Required!" Display="Dynamic">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" Font-Bold="True" ControlToValidate="txtQuantity" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid number." Display="Dynamic" ValidationExpression="\d+">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="UnitPrice" runat="server" text="Unit Price"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtUnitPrice" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" Width="5px" ControlToValidate="txtUnitPrice" ErrorMessage="unit price can't be blank." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ToolTip="Required!" Display="Dynamic">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Font-Bold="True" ControlToValidate="txtUnitPrice" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid price." Display="Dynamic" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator> </TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Label2" runat="server" Text="Discount"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtDiscoutInd" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" Font-Bold="True" ControlToValidate="txtDiscoutInd" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ToolTip="You must enter a valid price." Display="Dynamic" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Amount" runat="server" Text="Amount"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtAmount" runat="server" Width="185px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="lblRemarks" runat="server" text="Remarks"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtRemarks" runat="server" Width="532px" BorderStyle="Solid" BorderWidth="1px" maxlength="100"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"></TD><TD colSpan=3><asp:Button id="btnAdd" onclick="btnAdd_Click" runat="server" Width="57px" Text="Add" UseSubmitBehavior="False" ValidationGroup="PurchaseGroupTextField"></asp:Button></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="WIDTH: 799px"><TABLE width="100%"><TBODY></TBODY></TABLE><DIV style="OVERFLOW: auto; WIDTH: 618px; HEIGHT: 120px"><asp:GridView id="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowEdting" DataKeyNames="PK" EmptyDataText="Empty Data Table!" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting"><Columns>
<asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
<asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
<asp:BoundField DataField="Product Code" SortExpression="Product Code" HeaderText="Product Code"></asp:BoundField>
<asp:BoundField DataField="Product Name" SortExpression="Product Name" HeaderText="Product Name"></asp:BoundField>
<asp:BoundField DataField="Quantity" SortExpression="Quantity" HeaderText="Quantity"></asp:BoundField>
<asp:BoundField DataField="Rate" SortExpression="Rate" HeaderText="Rate"></asp:BoundField>
<asp:BoundField DataField="Discount" SortExpression="Discount" HeaderText="Discount"></asp:BoundField>
<asp:BoundField DataField="Total Amount" SortExpression="Total Amount" HeaderText="Total Amount"></asp:BoundField>
<asp:BoundField DataField="PK" Visible="False" SortExpression="PK" HeaderText="PK"></asp:BoundField>
<asp:BoundField DataField="Remarks" HeaderText="Remarks"></asp:BoundField>
</Columns>

<EditRowStyle BackColor="#FFFFC0"></EditRowStyle>
</asp:GridView> <asp:ValidationSummary id="ValidationSummary1" runat="server" ValidationGroup="PurchaseGroupTextField" ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary> </DIV></TD></TR><TR><TD style="WIDTH: 799px"><DIV style="OVERFLOW: scroll"></DIV></TD></TR><TR><TD style="WIDTH: 799px"><TABLE width="100%"><TBODY><TR><TD width="20%"></TD><TD width="25%"></TD><TD width="15%"><asp:Label id="Total" runat="server" text="Total Amount"></asp:Label></TD><TD width="40%"><asp:TextBox id="txtGroseTotal" runat="server" Width="139px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD width="20%"></TD><TD width="25%"></TD><TD width="15%"><asp:Label id="TotalDiscount" runat="server" text="Deduction"></asp:Label></TD><TD width="40%"><asp:TextBox id="txtDeduction" runat="server" Width="139px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox> </TD></TR><TR><TD width="20%"></TD><TD style="TEXT-ALIGN: right" width="25%"><asp:Button id="btnNew" runat="server" Width="60px" Text="New" UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="60px" Text="Save" UseSubmitBehavior="False" ValidationGroup="SalesGroupTextField"></asp:Button></TD><TD width="15%"><asp:Label id="lblReturnAmount" runat="server" text="Return Amount"></asp:Label></TD><TD width="40%"><asp:TextBox id="txtReturnAmount" runat="server" Width="139px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox> <asp:Button id="btnPrintBarcode" runat="server" Width="94px" Text="Print Barcode" UseSubmitBehavior="False" Visible="False" Enabled="False"></asp:Button> </TD></TR></TBODY></TABLE>&nbsp;</TD></TR></TBODY></TABLE></TD><TD width="2%"></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="WIDTH: 762px" vAlign=top align=left><asp:HiddenField id="hfSupplierPrimaryKey" runat="server"></asp:HiddenField><asp:HiddenField id="hfGRNNo" runat="server"></asp:HiddenField><asp:HiddenField id="hfPrimaryKey" runat="server"></asp:HiddenField> <asp:HiddenField id="hfProductCode" runat="server">
    </asp:HiddenField> <asp:HiddenField id="HiddenField1" runat="server" __designer:wfdid="w1"></asp:HiddenField> </TD></TR></TBODY></TABLE>&nbsp; </DIV>
</ContentTemplate>
        </asp:UpdatePanel>
 
</asp:Content>

