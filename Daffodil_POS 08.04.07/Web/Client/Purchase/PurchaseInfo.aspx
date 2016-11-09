<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme="DPOSThemes"  AutoEventWireup="true" CodeFile="PurchaseInfo.aspx.cs" Inherits="PurchaseInfo" MasterPageFile="~/MasterPage.master" Title="::.. Purchase Info ..::" %>


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

if (document.getElementById("ctl00_MainContent_txtTotalDiscount").value!="")
vTotalDiscount=document.getElementById("ctl00_MainContent_txtTotalDiscount").value;
  var vNetPayable=0;
 vNetPayable=(parseFloat(vTotalAmount) - parseFloat(vTotalDiscount));
document.getElementById("ctl00_MainContent_txtNetPayable").value=vNetPayable;
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
		var value=document.getElementById("ctl00_MainContent_txtDate").value;
		if(value.length==2){
		  document.getElementById("ctl00_MainContent_txtDate").value=document.getElementById("ctl00_MainContent_txtDate").value+"/";
		} else if(value.length==5){
		  document.getElementById("ctl00_MainContent_txtDate").value=document.getElementById("ctl00_MainContent_txtDate").value+"/20";
		}
	}	

function FocusControl_byEnter()
{
    if(event.keyCode==13)
         {
            
            if(document.activeElement.id=="ctl00_MainContent_txtRefno")
            {
                document.getElementById('ctl00_MainContent_txtDate').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtDate")
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
                document.getElementById('ctl00_MainContent_txtTotalDiscount').focus();
            }
           else if(document.activeElement.id=="ctl00_MainContent_txtTotalDiscount")
            {
                document.getElementById('ctl00_MainContent_btnSave').focus();
            }
        }
   else if(document.activeElement.id=="ctl00_MainContent_txtUnitPrice"
          ||document.activeElement.id=="ctl00_MainContent_txtDiscoutInd"
          ||document.activeElement.id=="ctl00_MainContent_txtAmount"
          ||document.activeElement.id=="ctl00_MainContent_txtTotalDiscount")
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
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 762px" vAlign=top align=left></TD></TR><TR><TD style="WIDTH: 762px" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="2%"></TD><TD style="WIDTH: 737px"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 799px"><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></TD></TR><TR><TD style="WIDTH: 799px"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 14%"><asp:Label id="SupplierCode" runat="server" text="Supplier Name"></asp:Label></TD><TD style="WIDTH: 31%" colSpan=2><asp:DropDownList id="ddlSupplierCode" runat="server" Width="191px" __designer:wfdid="w2"></asp:DropDownList>&nbsp;<asp:Button id="btnSupplierCode" runat="server" Width="15px" Height="22px" Font-Bold="True" Enabled="False" Visible="False" Text="..." UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnClickSupplierCode" onclick="btnClickSupplierCode_Click" runat="server" Width="1px" Height="10px" Text="." UseSubmitBehavior="False"></asp:Button></TD><TD style="WIDTH: 16%"><asp:Label id="PurchaseId" runat="server" text="Purchase ID" Enabled="False" Visible="False"></asp:Label></TD><TD style="WIDTH: 39%"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtPurchaseId" runat="server" Width="154px" BorderStyle="Solid" BackColor="Info" Enabled="False" Visible="False" BorderWidth="1px"></asp:TextBox>&nbsp;<asp:Button id="btnPurchaseID" runat="server" Width="30px" Height="22px" Font-Bold="True" Enabled="False" Visible="False" Text="..." UseSubmitBehavior="False"></asp:Button></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="SupplierName" runat="server" Width="95px" text="Supplier Name" Enabled="False" Visible="False"></asp:Label></TD><TD style="WIDTH: 31%" colSpan=4><asp:TextBox id="txtSupplierName" runat="server" Width="531px" BorderStyle="Solid" BackColor="Info" Enabled="False" Visible="False" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Address" runat="server" text="Address"></asp:Label></TD><TD style="WIDTH: 31%" colSpan=4><asp:TextBox id="txtSupplierAddress" runat="server" Width="532px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Refno" runat="server" text="Ref. No"></asp:Label></TD><TD style="WIDTH: 31%" colSpan=2><asp:TextBox id="txtRefno" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="15"></asp:TextBox></TD><TD style="WIDTH: 16%"><asp:Label id="Date" runat="server" text="Date"></asp:Label></TD><TD style="WIDTH: 39%"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtDate" runat="server" Width="153px" BorderStyle="Solid" BorderWidth="1px" maxlength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox><IMG style="WIDTH: 37px" id="imgPurchaseDate" alt="Pick Date" src="../../Images/calendar.gif" /> <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" Width="5px" __designer:wfdid="w4" ToolTip="Please enter a valid date, " ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="*" ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True">*</asp:RequiredFieldValidator><asp:RangeValidator id="RangeValidator2" runat="server" __designer:dtid="3096224743817248" __designer:wfdid="w19" ToolTip="Please enter a valid date." ControlToValidate="txtDate" ErrorMessage="*" SetFocusOnError="True" Type="Date" MinimumValue="01/01/1973" MaximumValue="01/01/2999"></asp:RangeValidator>
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
                          </asp:DropDownList> <asp:Button id="btnClickPurductName" onclick="btnClickPurductName_Click" runat="server" Width="1px" Height="1px" __designer:wfdid="w2" Text="." UseSubmitBehavior="False"></asp:Button> <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" __designer:wfdid="w1" ControlToValidate="ddlProductName" ErrorMessage="Select a product" ValidationGroup="ProductGroupTextField" SetFocusOnError="True">*</asp:RequiredFieldValidator></TD><TD style="WIDTH: 16%"><asp:Label id="CurrentBalance" runat="server" text="Current Balance" Enabled="False" Visible="False"></asp:Label></TD><TD style="WIDTH: 38%"><asp:TextBox id="txtCurrentBalance" runat="server" Width="188px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" Enabled="False" Visible="False" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Quantity" runat="server" text="Quantity"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtQuantity" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="5px" ToolTip="Required!" ControlToValidate="txtQuantity" Display="Dynamic" ErrorMessage="Please enter  quantity, " ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" Font-Bold="True" ToolTip="You must enter a valid number." ControlToValidate="txtQuantity" Display="Dynamic" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ValidationExpression="\d+">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="UnitPrice" runat="server" text="Unit Price"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtUnitPrice" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" Width="5px" ToolTip="Required!" ControlToValidate="txtUnitPrice" Display="Dynamic" ErrorMessage="unit price can't be blank." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Font-Bold="True" ToolTip="You must enter a valid price." ControlToValidate="txtUnitPrice" Display="Dynamic" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator> </TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Label2" runat="server" Text="Discount"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtDiscoutInd" runat="server" Width="185px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" Font-Bold="True" ToolTip="You must enter a valid price." ControlToValidate="txtDiscoutInd" Display="Dynamic" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Amount" runat="server" Text="Amount"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtAmount" runat="server" Width="185px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="lblRemarks" runat="server" text="Remarks"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtRemarks" runat="server" Width="528px" BorderStyle="Solid" BorderWidth="1px" maxlength="100"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"></TD><TD colSpan=3><asp:Button id="btnAdd" onclick="btnAdd_Click" runat="server" Width="57px" Text="Add" UseSubmitBehavior="False" ValidationGroup="PurchaseGroupTextField"></asp:Button></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="WIDTH: 799px"><TABLE width="100%"><TBODY></TBODY></TABLE><DIV style="OVERFLOW: auto; WIDTH: 618px; HEIGHT: 120px"><asp:GridView id="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowEdting" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" DataKeyNames="PK" EmptyDataText="Empty Data Table!" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"><Columns>
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
</asp:GridView> <asp:ValidationSummary id="ValidationSummary1" runat="server" ValidationGroup="PurchaseGroupTextField" ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary> </DIV></TD></TR><TR><TD style="WIDTH: 799px"><DIV style="OVERFLOW: scroll"></DIV></TD></TR><TR><TD style="WIDTH: 799px"><TABLE width="100%"><TBODY><TR><TD width="20%"></TD><TD width="25%"></TD><TD width="15%"><asp:Label id="Total" runat="server" text="Total Amount"></asp:Label></TD><TD width="40%"><asp:TextBox id="txtGroseTotal" runat="server" Width="139px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD width="20%"></TD><TD width="25%"></TD><TD width="15%"><asp:Label id="TotalDiscount" runat="server" text="Total Discount"></asp:Label></TD><TD width="40%"><asp:TextBox id="txtTotalDiscount" runat="server" Width="139px" BorderStyle="Solid" BorderWidth="1px" maxlength="9"></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator4" runat="server" Font-Bold="True" ToolTip="You must enter a valid price." ControlToValidate="txtTotalDiscount" Display="Dynamic" ErrorMessage="You must enter a valid price." ValidationGroup="PurchaseGroupTextField" SetFocusOnError="True" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR><TD width="20%"></TD><TD style="TEXT-ALIGN: right" width="25%"><asp:Button id="btnNew" runat="server" Width="60px" Text="New" UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="60px" Text="Save" UseSubmitBehavior="False" ValidationGroup="SalesGroupTextField"></asp:Button></TD><TD width="15%"><asp:Label id="NetPayable" runat="server" text="Net Payable"></asp:Label></TD><TD width="40%"><asp:TextBox id="txtNetPayable" runat="server" Width="139px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox> <asp:Button id="btnPrintBarcode" runat="server" Width="94px" Enabled="False" Visible="False" Text="Print Barcode" UseSubmitBehavior="False"></asp:Button> </TD></TR></TBODY></TABLE>&nbsp;</TD></TR></TBODY></TABLE></TD><TD width="2%"></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="WIDTH: 762px" vAlign=top align=left><asp:HiddenField id="hfSupplierPrimaryKey" runat="server"></asp:HiddenField><asp:HiddenField id="HiddenField1" runat="server"></asp:HiddenField><asp:HiddenField id="hfPrimaryKey" runat="server"></asp:HiddenField> <asp:HiddenField id="hfProductCode" runat="server">
    </asp:HiddenField> </TD></TR></TBODY></TABLE>&nbsp; </DIV>
</ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
