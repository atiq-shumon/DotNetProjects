using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Xml;
using System.IO;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;
using DSL.POS.Report;


public partial class SalesInfo : System.Web.UI.Page 
{
    protected DataTable myDt;
    Guid guidSalesMain_Pk_Code;
    ClsErrorHandle cls = new ClsErrorHandle();
    private ReportDocument oReportDocument = new ReportDocument();
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["salesuserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }


        if (!IsPostBack)
        {

            ddlProductName.Attributes.Add("onkeypress", "clickbtn('" + btnClickProduct_ddl.ClientID + "')");
            txtProduct.Attributes.Add("onkeypress", "clickbtn('" + btnClickProductCode.ClientID + "')");

            txtQuantity.Attributes.Add("onkeypress", "clickbtn('" + btnAdd.ClientID + "')");
            txtCustomerId.Attributes.Add("onkeypress", "clickbtn('" + btnClickMemberID.ClientID + "')");
            //txtProduct.Attributes.Add("onkeypress", "clickbtn('" + btnClickProductCode.ClientID + "')");

            //txtQuantity.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtDiscountTotal.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            ddlPaymentMode.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            txtPaymentAmount.Attributes.Add("onkeypress", "FocusControl_byEnter()");


            txtDiscountTotal.Attributes.Add("onKeyUp", "CalculatePaidAmount()");
            txtPaymentAmount.Attributes.Add("onKeyUp", "CalculateRetrunDue()");

            // fill drop down list
            Facade facade = Facade.GetInstance();
            DropDownListProduct(facade);

            // Create Temporary Table in Session for Store Product Information
            CreateTableInSession();

            this.txtProduct.Focus();
            this.txtDate.Text = DateTime.Now.ToString();
            this.ddlPaymentMode.Items.Add("Credit");
            this.ddlPaymentMode.Items.Add("Cash");
            this.ddlPaymentMode.Items.Add("Cheque");
            
        }        
    }
    private void DropDownListProduct(Facade facade)
    {
        IProductInfoBL oIProductInfoBL = facade.GetProductInfoInstance();
        List<ProductInfoDTO> oCategoryList = oIProductInfoBL.GetProductInfo();

        int i = 0;
        ddlProductName.Items.Clear();
        ddlProductName.Items.Add("(Select any category)");
        this.ddlProductName.Items[i].Value = "";
        foreach (ProductInfoDTO newDto in oCategoryList)
        {
            i++;
            this.ddlProductName.Items.Add(newDto.P_Name);
            this.ddlProductName.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    /// All Method is available under the block
    #region All_Method

    /// <summary>
    /// Create A New Table And keep in Session
    /// </summary>
    protected void CreateTableInSession()
    {
        //Initialize data table
        myDt = new DataTable();
        //create data table: column, data type, name
        myDt = CreateDataTable();
        //Keep data table in session
        Session["myDatatable"] = myDt;
        //Convert data table from session, put data source for grid view
        this.GridView1.DataSource = ((DataTable)Session["myDatatable"]).DefaultView;
        //Bind grid            
        this.GridView1.DataBind();
    }

    /// <summary>
    /// Create data table 
    /// </summary>
    /// <returns>Data table</returns>
    private DataTable CreateDataTable()
    {
        DataTable myDataTable = new DataTable("SalesSub");

        DataColumn myDataColumn;

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Product Code";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Product Name";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Quantity";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Rate";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "VAT";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "TAX";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Discount";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Total Amount";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.Guid");
        myDataColumn.ColumnName = "PK";
        myDataTable.Columns.Add(myDataColumn);

        return myDataTable;
    }

    /// <summary>
    /// Create data table for Invoice
    /// </summary>
    /// <returns>Data table</returns>
    private DataTable CreateDataTableInvoice()
    {
        DataTable myDataTableInvoice = new DataTable("SalesMain");

        DataColumn myDataColumn;

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.Guid");
        myDataColumn.ColumnName = "PK";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "InvoiceNo";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "InvoiceDate";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "MemberID";
        myDataColumn.AllowDBNull=true;
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "MemberName";
        myDataColumn.AllowDBNull = true;
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "MemberAddress";
        myDataColumn.AllowDBNull = true;
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "DipositBalance";
        myDataColumn.AllowDBNull = true;
        myDataTableInvoice.Columns.Add(myDataColumn);
                
        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Discount";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "PaymentMode";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "PaymentAmount";
        myDataTableInvoice.Columns.Add(myDataColumn);        

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "PaidAmount";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "ReturnAmount";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "DueAmount";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "TotalAmount";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSProductCode";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSProductName";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSQuantity";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSRate";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSVAT";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSTAX";
        myDataTableInvoice.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "SSDiscount";
        myDataTableInvoice.Columns.Add(myDataColumn);        

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.Guid");
        myDataColumn.ColumnName = "SSPK";
        myDataTableInvoice.Columns.Add(myDataColumn);
        return myDataTableInvoice;
    }
    
    /// <summary>
    /// Add in Table Sales Main & Sub Information
    /// </summary>
    /// <param name="myTable">DataTable Main</param>
    /// <param name="subTable">DataTable Sub</param>
    /// <param name="strInvoiceNo">Invoice No</param>
    private void AddRowInTableSalesMain(ref DataTable myTable,DataTable subTable,string strInvoiceNo)
    {
        try
        {
            int rowNo = 0;
            int totalRows = 0;

            // total datatable's rows keep in local variable 
            totalRows = subTable.Rows.Count;

            for (rowNo = 0; rowNo < totalRows; rowNo++)
            {
                DataRow row;

                row = myTable.NewRow();
                row["PK"] = this.hfMemberPK.Value;
                row["InvoiceNo"] = strInvoiceNo;
                row["InvoiceDate"] = DateTime.Now.Date;
                row["MemberID"] = this.txtCustomerId.Text;
                row["MemberName"] = this.txtCustomerName.Text;
                row["MemberAddress"] = this.txtAddress.Text;
                row["DipositBalance"] = (this.txtDepositBalance.Text.Trim() == string.Empty ? "0" : this.txtDepositBalance.Text.Trim());
                row["TotalAmount"] = this.txtTotalAmount.Text;
                row["Discount"] = (this.txtDiscountTotal.Text.Trim() == string.Empty ? "0" : this.txtDiscountTotal.Text.Trim());
                row["PaymentMode"] = this.ddlPaymentMode.Text;
                row["PaymentAmount"] = (this.txtPaymentAmount.Text.Trim() == string.Empty ? "0" : this.txtPaymentAmount.Text.Trim());
                row["PaidAmount"] = (this.txtPaidAmount.Text.Trim() == string.Empty ? "0" : this.txtPaidAmount.Text.Trim());
                row["ReturnAmount"] = (this.txtReturnAmount.Text.Trim() == string.Empty ? "0" : this.txtReturnAmount.Text.Trim());
                row["DueAmount"] = (this.txtDue.Text.Trim() == string.Empty ? "0" : this.txtDue.Text.Trim());
                row["TotalAmount"] = this.txtTotalAmount.Text.Trim();
                row["SSProductCode"] = subTable.Rows[rowNo][0];
                row["SSProductName"] = subTable.Rows[rowNo][1];
                row["SSQuantity"] = subTable.Rows[rowNo][2];
                row["SSRate"] = subTable.Rows[rowNo][3];
                row["SSVAT"] = subTable.Rows[rowNo][4];
                row["SSTAX"] = subTable.Rows[rowNo][5];
                row["SSDiscount"] = subTable.Rows[rowNo][6];
                row["SSPK"] = subTable.Rows[rowNo][8];

                myTable.Rows.Add(row);
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    /// <summary>
    /// Get Total Amount all Entry product amount
    /// </summary>
    /// <returns>decimal</returns>
    private decimal GetTotalAmount()
    {
        decimal totalAmount = 0;
        int rowNo = 0;
        int totalRows = 0;

        DataTable myDataTable = new DataTable();
        myDataTable = ((DataTable)Session["myDatatable"]);
        totalRows = myDataTable.Rows.Count;

        for (rowNo = 0; rowNo < totalRows; rowNo++)
        {
            totalAmount = totalAmount + Convert.ToDecimal(myDataTable.Rows[rowNo][7]);
        }
        return totalAmount;
    }

    /// <summary>
    /// Add New Raw In table
    /// </summary>
    /// <param name="ProductCode"></param>
    /// <param name="strProductName"></param>
    /// <param name="quantity"></param>
    /// <param name="rate"></param>
    /// <param name="vat"></param>
    /// <param name="tax"></param>
    /// <param name="discount"></param>
    /// <param name="myTable"></param>
    private void AddDataToTable(string ProductCode, string strProductName,
                    string quantity, string rate, string vat, string tax,
                        string discount, string P_PK, DataTable myTable)
    {
        try
        {
            DataRow row;
            row = myTable.NewRow();
            row["Product Code"] = ProductCode;
            row["Product Name"] = strProductName;
            row["Quantity"] = quantity;
            row["Rate"] = rate;
            row["VAT"] = vat;
            row["TAX"] = tax;
            row["Discount"] = discount;
            row["Total Amount"] = ((Convert.ToDecimal(rate) + Convert.ToDecimal(tax) +
                                    Convert.ToDecimal(vat)) * Convert.ToDecimal(quantity))
                                    - (Convert.ToDecimal(discount) * Convert.ToDecimal(quantity));
            //row["PK"]=Guid
            Guid p_pk = new Guid(P_PK);
            row["PK"] = p_pk;

            myTable.Rows.Add(row);
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }
    /// <summary>
    /// Update Product Sales rate & discount
    /// </summary>
    protected void Update_Product()
    {
        try
        {
            
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();
            if (this.txtProduct.Text.Length != 13)
            {
                Guid productguid = Guid.NewGuid();
                productguid = ((Guid)TypeDescriptor.GetConverter(productguid).ConvertFromString(this.ddlProductName.SelectedValue));
                objCmd.CommandText = "Update ProductInfo Set P_SalesPrice=@P_SalesPrice,P_Discount=@P_Discount,EntryBy=@EntryBy,EntryDate=@EntryDate Where P_PK=@P_PK";
                objCmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier , 16));
                objCmd.Parameters["@P_PK"].Value = productguid;

            }
            else
            {
                objCmd.CommandText = "Update ProductInfo Set P_SalesPrice=@P_SalesPrice,P_Discount=@P_Discount,EntryBy=@EntryBy,EntryDate=@EntryDate Where P_Code=@P_Code";
                objCmd.Parameters.Add(new SqlParameter("@P_Code", SqlDbType.VarChar, 13));
                objCmd.Parameters["@P_Code"].Value = this.txtProduct.Text;
            }
            
            objCmd.Parameters.Add(new SqlParameter("@P_SalesPrice", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_Discount", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 6));
            objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime, 8));
            objCmd.Parameters["@P_SalesPrice"].Value = this.txtRate.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtRate.Text.Trim());
            objCmd.Parameters["@P_Discount"].Value = this.txtDiscount.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscount.Text.Trim());
            objCmd.Parameters["@EntryBy"].Value = Convert.ToString(User.Identity.Name);
            objCmd.Parameters["@EntryDate"].Value = DateTime.Now.Date;
            objCmd.Connection = objMyCon;
            objMyCon.Open();
            objCmd.ExecuteNonQuery();
            objMyCon.Close();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            
        }

    }
    /// <summary>
    /// set up data in Grid View 
    /// </summary>
    protected void Get_Data_InTable()
    {
        try
        {
            int count = 0;
            int rowNo = 0;
            int totalRows = 0;

            if (txtProduct.Text.Trim() == "")
            {
                this.lblErrorMessage.Text = "You must fill a Product Code.";
                return;
            }
            else if (txtQuantity.Text.Trim() == "")
            {
                this.lblErrorMessage.Text = "You must fill a Quantity.";
                return;
            }
            else if (txtRate.Text.Trim() == "")
            {
                this.lblErrorMessage.Text = "You must fill a Rate.";
                return;
            }
            else
            {
                this.lblErrorMessage.Text = "";

                // create data table
                DataTable myDataTable = new DataTable();
                myDataTable = ((DataTable)Session["myDatatable"]);
                // total datatable's rows keep in local variable 
                totalRows = myDataTable.Rows.Count;

                for (rowNo = 0; rowNo < totalRows; rowNo++)
                {
                    //we get the Hidden Fields value if user try to insert same product
                    // or update inserted product

                    if (this.HiddenField1.Value != "")
                    {
                        // under declear condition will execute when user want to update 
                        // Existing product information
                        if (Convert.ToString(this.HiddenField1.Value) == (string)myDataTable.Rows[rowNo][0])
                        {
                            myDataTable.Rows[rowNo][0] = this.txtProduct.Text;
                            myDataTable.Rows[rowNo][1] = this.txtProductName.Text;
                            myDataTable.Rows[rowNo][2] = this.txtQuantity.Text.Trim();
                            myDataTable.Rows[rowNo][3] = this.txtRate.Text.Trim();
                            myDataTable.Rows[rowNo][4] = this.hfVat.Value.Trim();
                            myDataTable.Rows[rowNo][5] = this.hfTax.Value.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.hfTax.Value.Trim());
                            myDataTable.Rows[rowNo][6] = this.txtDiscount.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscount.Text.Trim());

                            myDataTable.Rows[rowNo][7] = (((this.txtRate.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtRate.Text.Trim())) +
                                       (this.hfVat.Value.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.hfVat.Value.Trim())) +
                                       (this.hfTax.Value.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.hfTax.Value.Trim()))) *
                                       (this.txtQuantity.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text.Trim()))) -
                                       ((this.txtDiscount.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscount.Text.Trim())) *
                                       (this.txtQuantity.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text.Trim())));
                            myDataTable.Rows[rowNo][8] = this.hfP_PK.Value.ToString();

                            count = 1;
                            this.HiddenField1.Value = "";
                            this.btnAdd.Text = "Add";
                            this.hfP_PK.Value = "";

                            break;
                        }

                        else
                            count = 0;
                    }

                    // under declear condition will execute when user want to insert 
                    // same product information
                    else if (this.txtProduct.Text.Trim() == myDataTable.Rows[rowNo][0].ToString())
                    {
                        string addQuantity;
                        decimal totalQuantity = 0;

                        addQuantity = myDataTable.Rows[rowNo][2].ToString();
                        totalQuantity = (this.txtQuantity.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text.Trim())) + Convert.ToDecimal(addQuantity);

                        myDataTable.Rows[rowNo][2] = totalQuantity.ToString();

                        myDataTable.Rows[rowNo][7] = (((this.txtRate.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtRate.Text.Trim())) +
                                    (this.hfVat.Value.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.hfVat.Value.Trim())) +
                                    (this.hfTax.Value.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.hfTax.Value.Trim()))) *
                                    (totalQuantity)) -
                                    ((this.txtDiscount.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscount.Text.Trim())) *
                                    (totalQuantity));
                        myDataTable.Rows[rowNo][8] = this.hfP_PK.Value.ToString();
                        this.btnAdd.Text = "Add";
                        count = 1;
                        this.HiddenField1.Value = "";
                        break;
                    }
                    else
                        count = 0;
                }
                if (count == 0)
                {
                    // under declare the statement will execute when user try to insert in new product information.
                    AddDataToTable(this.txtProduct.Text.Trim(), this.txtProductName.Text.Trim(),
                        this.txtQuantity.Text.Trim(), this.txtRate.Text.Trim(),
                        this.hfVat.Value.Trim(), this.hfTax.Value.Trim(),
                        this.txtDiscount.Text.Trim(), this.hfP_PK.Value.ToString(),
                        (DataTable)Session["myDatatable"]);
                }
                // Bind Table With Session
                this.GridView1.DataSource = ((DataTable)Session["myDatatable"]).DefaultView;
                this.GridView1.DataBind();

                //clear input texts
                this.ddlProductName.SelectedValue = "";
                this.txtProduct.Text = "";
                this.txtQuantity.Text = "";
                this.txtRate.Text = "";
                this.hfVat.Value = "";
                this.hfTax.Value = "";
                this.txtQuantity.Text = "";
                this.txtProductName.Text = "";
                this.txtDiscount.Text = "";
                this.btnAdd.Text = "Add";
                this.hfP_PK.Value = "";
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            // update Total Amount, Dur Amount , Paid Amount 
            // when user insert new or update Product information.
            this.txtTotalAmount.Text = GetTotalAmount().ToString("#####.#0");
            this.txtPaidAmount.Text = GetTotalAmount().ToString("#####.#0");
            this.txtDue.Text = GetTotalAmount().ToString("#####.#0");
        }
    }     


    # endregion

    /// <summary>
    /// Save the Information in Grid View
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            this.Update_Product();
            this.Get_Data_InTable();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            ScriptManager1.SetFocus(txtProduct);
        }
    }

    
    /// <summary>
    /// Entey Product update or delete
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_RowEdting(object sender, GridViewCommandEventArgs e)
    {

        //===========================================================
        // under the variable used for Data delele
        DataTable myDataTable = new DataTable();
        int rowNo = 0;
        int totalRows = 0;
        //============================================================    

        try
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                DataKey xx = this.GridView1.DataKeys[index];
                
                this.hfP_PK.Value= xx.Value.ToString();

                this.txtProduct.Text = Server.HtmlDecode(row.Cells[2].Text);
                this.txtProductName.Text = Server.HtmlDecode(row.Cells[3].Text);
                this.txtQuantity.Text = Server.HtmlDecode(row.Cells[4].Text);
                this.txtRate.Text = Server.HtmlDecode(row.Cells[5].Text.Trim());
                //this.hfVat.Value = Server.HtmlDecode(row.Cells[6].Text);
                this.hfTax.Value = Server.HtmlDecode(row.Cells[7].Text.Trim());
                this.txtDiscount.Text = Server.HtmlDecode(row.Cells[7].Text.Trim());
                this.btnAdd.Text = "Update";
                this.HiddenField1.Value = row.Cells[2].Text;                
            }
            if (e.CommandName == "Delete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                this.HiddenField1.Value = row.Cells[2].Text;

                myDataTable = ((DataTable)Session["myDatatable"]);
                totalRows = myDataTable.Rows.Count;

                for (rowNo = 0; rowNo < totalRows; rowNo++)
                {
                    if (Convert.ToString(HiddenField1.Value) == (string)myDataTable.Rows[rowNo][0])
                    {
                        myDataTable.Rows.RemoveAt(rowNo);
                        break;
                    }
                }

                this.GridView1.DataSource = ((DataTable)Session["myDatatable"]).DefaultView;
                this.GridView1.DataBind();

                // for get update Total, Due , Paid Amount after delete any Product inserted formation            
                this.txtTotalAmount.Text = GetTotalAmount().ToString("#####.#0");
                this.txtPaidAmount.Text = GetTotalAmount().ToString("#####.#0");
                this.txtDue.Text = GetTotalAmount().ToString("#####.#0");
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);

        }
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        
        try
        {
            string strInvoiceNo = null;
            
            //
            DataSet ds = new DataSet();

            // create Data Table object for sales sub
            DataTable myDataTable = new DataTable();

            // create Data Table object for sales Main
            DataTable myDataTableSalesMain = new DataTable();
            // //create data table: column, data type, name
            myDataTableSalesMain=CreateDataTableInvoice();

            myDataTable = ((DataTable)Session["myDatatable"]);

            SalesMainInfoDTO dto = populate(ref strInvoiceNo);
            if ((this.txtCustomerId.Text.Length == 0) && (this.ddlPaymentMode.SelectedValue == "Credit"))
            {
                this.lblErrorMessage.Text = "Enter a Member ID";
                return;
            }
            if (dto.SalesSubInfoDTO.Count == 0)
            {
                this.lblErrorMessage.Text = "Have to insert at least one product.";
                return;
            }

            Facade facade = Facade.GetInstance();
            ISalesInfoBL oISalesInfoBL = facade.createSalesBL();
            oISalesInfoBL.addNewSalesInfo(dto);

            this.AddRowInTableSalesMain(ref myDataTableSalesMain,myDataTable, strInvoiceNo);
            ds.Tables.Add(myDataTableSalesMain);
            
            string crPath = "CrysSalesInvoice.rpt";
            string reportPath = Server.MapPath(crPath);
            oReportDocument.Load(reportPath);
            oReportDocument.SetDataSource(ds.Tables[0]);       

            CommonViewer.CRReportDefinition = oReportDocument;
            Response.Redirect("~/Client/Sales/ReportViewer.aspx");

            
            //===========Clear Text Box and GridView5========================
            this.hfMemberPK.Value = "";
            this.hfP_PK.Value = "";
            this.HiddenField1.Value = "";
            this.txtCustomerId.Text = "";
            this.txtCustomerName.Text = "";
            this.txtAddress.Text = "";
            this.txtDepositBalance.Text = "";
            this.txtDiscount.Text = "";
            this.txtDiscountTotal.Text = "";
            this.txtDue.Text = "";
            this.txtInvoiceNo.Text = "";
            this.txtPaidAmount.Text = "";
            this.txtPaymentAmount.Text = "";
            this.txtProduct.Text = "";
            this.txtQuantity.Text = "";
            this.txtRate.Text = "";
            this.txtReturnAmount.Text = "";
            this.hfTax.Value = "";
            this.hfVat.Value = "";
            this.txtTotalAmount.Text = "";
            this.txtDepositBalance.Text = "";
            this.pnlMember.Visible = false;

            myDataTable.Clear();
            myDataTable.Reset();
            myDataTableSalesMain.Clear();
            myDataTableSalesMain.Reset();

            this.GridView1.DataSource = myDataTable.DefaultView;
            this.GridView1.DataBind();

            // Create a New Session and Table
            CreateTableInSession();
            //==============================================================
            this.lblSuccessMessage.Text = "Data Save Successfully.";
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    private Guid Get_Booth_PK()
    {
        Guid BoothID = Guid.NewGuid();
        if (Request.Cookies["DPOS"] != null)
        {
            string strBoothID = "";

            if (Request.Cookies["DPOS"]["BoothNo"] != null)
            {
                strBoothID = Request.Cookies["DPOS"]["BoothNo"];


                BoothInfoDTO dto = new BoothInfoDTO();
                // populate dto

                //Facade facade = Facade.GetInstance();

                // PK keep in local variable 
                BoothID = (Guid)TypeDescriptor.GetConverter(BoothID).ConvertFromString(strBoothID);
            }
        }
        
        return BoothID;
    }


    /// <summary>
    /// set up Sales Main And Sub DTO
    /// </summary>
    /// <returns></returns>
    public SalesMainInfoDTO populate(ref string  strInvoiceNo)
    {
        
        // generate Invoice Number combination of Year+Month+Day+Hour+Minute+Second
        strInvoiceNo = "01";
        strInvoiceNo = strInvoiceNo + Convert.ToString(DateTime.Today.Year);            
        strInvoiceNo = strInvoiceNo + Convert.ToString( DateTime.Today.Month.ToString("00"));
        strInvoiceNo = strInvoiceNo + Convert.ToString(DateTime.Today.Day.ToString("00"));
        strInvoiceNo = strInvoiceNo + Convert.ToString(DateTime.Now.Hour.ToString("00"));
        strInvoiceNo = strInvoiceNo + Convert.ToString(DateTime.Now.Minute.ToString("00"));
        strInvoiceNo = strInvoiceNo + Convert.ToString(DateTime.Now.Second.ToString("00"));

        SalesMainInfoDTO oSalesMainInfoDTO = new SalesMainInfoDTO();
        List<SalesSubInfoDTO> lSalesSubInfoDTO = new List<SalesSubInfoDTO>();        
        
        try
        {
            int rowNo = 0;
            int totalRows = 0;

            DataTable myDataTable = new DataTable();           

            guidSalesMain_Pk_Code = Guid.NewGuid();
            
            oSalesMainInfoDTO.PrimaryKey = guidSalesMain_Pk_Code;

            if ((this.hfMemberPK.Value.ToString()) == "")
            {
                oSalesMainInfoDTO.Cust_PK =new Guid("00000000-0000-0000-0000-000000000000") ;
            }
            else
                oSalesMainInfoDTO.Cust_PK = new Guid(this.hfMemberPK.Value.ToString());;

            // for update Sales Main Primary Key in Data Table
            // for using relation in Sales Main & Sub Table.
            this.hfMemberPK.Value = guidSalesMain_Pk_Code.ToString();

            oSalesMainInfoDTO.DeliveryDate = DateTime.Now.Date;
            oSalesMainInfoDTO.DeliveryNo = strInvoiceNo;
            
            if (this.txtPaidAmount.Text.Length != 0)
                oSalesMainInfoDTO.PaidAmount = (Decimal)TypeDescriptor.GetConverter(oSalesMainInfoDTO.PaidAmount).ConvertFromString(this.txtPaidAmount.Text);
            else
                oSalesMainInfoDTO.PaidAmount = 0;

            if (this.txtPaymentAmount.Text.Length != 0)
                oSalesMainInfoDTO.PaymentAmount = (Decimal)TypeDescriptor.GetConverter(oSalesMainInfoDTO.PaymentAmount).ConvertFromString(this.txtPaymentAmount.Text);
            else
                oSalesMainInfoDTO.PaymentAmount = 0;

            oSalesMainInfoDTO.PaymentMode = this.ddlPaymentMode.Text;
            oSalesMainInfoDTO.Remarks = "Good";


            oSalesMainInfoDTO.Bo_PK = Get_Booth_PK();
           
            oSalesMainInfoDTO.TotalAmount = (Decimal)TypeDescriptor.GetConverter(oSalesMainInfoDTO.TotalAmount).ConvertFromString(this.txtTotalAmount.Text);

            if (this.txtDue.Text.Length != 0)
                oSalesMainInfoDTO.DueAmount = Decimal.Parse(this.txtDue.Text);
            else
                oSalesMainInfoDTO.DueAmount = 0;

            if (this.txtDiscountTotal.Text.Length != 0)
                oSalesMainInfoDTO.TotalDiscount = Decimal.Parse(this.txtDiscountTotal.Text);
            else
                oSalesMainInfoDTO.TotalDiscount = 0;

            //================================Get Data From Table/GridView for SalesSub=====================
            
            myDataTable = ((DataTable)Session["myDatatable"]);
            totalRows = myDataTable.Rows.Count;

            for (rowNo = 0; rowNo < totalRows; rowNo++)
            {
                // call SetSalesSubInfoDTO method for
                // set up in Sales Sub Domin all information from Data Table
                SalesSubInfoDTO oSalesSubInfoDTO = SetSalesSubInfoDTO(rowNo,guidSalesMain_Pk_Code,myDataTable);
               
                // Add one by one Sales Sub Information in List
                lSalesSubInfoDTO.Add(oSalesSubInfoDTO);                   
            }
            // 
            oSalesMainInfoDTO.SalesSubInfoDTO = lSalesSubInfoDTO;
            oSalesMainInfoDTO.EntryBy = User.Identity.Name;            
          
            //====================================================================================
            
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        return oSalesMainInfoDTO;
    }

    /// <summary>
    /// set up sales sub information from the date table
    /// </summary>
    /// <param name="rowNo"></param>
    /// <param name="guidSM"></param>
    /// <param name="myDataTable"></param>
    /// <returns>SalesSubInfoDTO</returns>
    protected SalesSubInfoDTO SetSalesSubInfoDTO(int rowNo, Guid guidSM, DataTable myDataTable)
    {
        //dto.Sal_Pk = guidSalesMain_Pk_Code;
        SalesSubInfoDTO dto = new SalesSubInfoDTO();
        dto.Sal_Pk = guidSM;
        dto.P_PK = (Guid)myDataTable.Rows[rowNo][8];
        dto.SalesQuantity = Decimal.Parse(myDataTable.Rows[rowNo][2].ToString());
        dto.SalesRate = Decimal.Parse(myDataTable.Rows[rowNo][3].ToString());
        dto.VatAmount = Decimal.Parse(myDataTable.Rows[rowNo][4].ToString());
        dto.TaxAmount = Decimal.Parse(myDataTable.Rows[rowNo][5].ToString());
        dto.Discount = Decimal.Parse(myDataTable.Rows[rowNo][6].ToString());
        dto.TotalAmount = Decimal.Parse(myDataTable.Rows[rowNo][7].ToString());
        dto.EntryBy = User.Identity.Name;
        dto.EntryDate = DateTime.Now.Date;

        return dto;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Fill Text Box Corresponding the Customer Code.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClickMemberID_Click(object sender, EventArgs e)
    {
        try
        {
            long lCustID = 0;
            string strCustID = "";

            MemberInfoDTO dto = new MemberInfoDTO();

            Facade facade = Facade.GetInstance();

            // member id keep in local variable for cust format
            lCustID = long.Parse(this.txtCustomerId.Text);
            // format in member ID
            strCustID = lCustID.ToString("000000");
            //  Get the Member Information Corresponding member code and keep Member Info Domain Object
            dto = facade.getMemberInfo(facade.getMemberPKInfoByCode(strCustID));
            // set up the member primary code in local declared Hidden field
            this.hfMemberPK.Value = dto.PrimaryKey.ToString();

            if (this.hfMemberPK.Value != "00000000-0000-0000-0000-000000000000")
            {
                this.lblErrorMessage.Text = "";
                pnlMember.Visible = true;
            }
            else
            {
                pnlMember.Visible = false;
                this.txtCustomerId.Text = "";
                this.lblErrorMessage.Text = "Member Not Available. Please Insert Correct Member ID.";
                return;
            }

            this.txtCustomerId.Text = dto.CustId;
            this.txtCustomerName.Text = dto.CustName;
            this.txtAddress.Text = dto.CustAddr;
            this.txtDepositBalance.Text = dto.CreditLimit.ToString("#####.#0");
            this.txtProduct.Focus();

        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            ScriptManager1.SetFocus(txtProduct);
        }
    }

    protected void btnClickProductCode_Click(object sender, EventArgs e)
    {
        this.ProductCode_click();
    }
    protected void btnClickProduct_ddl_Click(object sender, EventArgs e)
    {
        this.ProductCode_click();
        this.ddlProductName.SelectedValue = "";
    }
    protected void ProductCode_click()
    {
        try
        {
            if ((this.lblErrorMessage.Text.Length != 0) || (this.lblSuccessMessage.Text.Length != 0))
            {
                this.lblSuccessMessage.Text = "";
                this.lblErrorMessage.Text = "";
            }
            // Create the Product Info Domain Instance
            ProductInfoDTO dto = new ProductInfoDTO();

            // Create the facade Instance
            Facade facade = Facade.GetInstance();
            // Get the Product Info Corresponding Primary key or Product Code and keep those information
            if (this.txtProduct.Text.Length != 0)
            {
                dto = facade.GetProductInfoDTO((Guid)(facade.getProductPKInfoByCode((string)(this.txtProduct.Text))));
            }
            else
            {
                dto = facade.GetProductInfoDTO((Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.ddlProductName.SelectedValue));
            }
            // keep the product Product primary key(GUID) in Local Hidden Field 
            //for use insert in temporary table
            this.hfP_PK.Value = dto.PrimaryKey.ToString();

            //set up product information in domain properties
            if (this.hfP_PK.Value != "00000000-0000-0000-0000-000000000000")
            {
                this.txtProduct.Text = dto.P_Code;
                this.txtProductName.Text = dto.P_Name;
                this.txtRate.Text = dto.P_SalesPrice.ToString("#####.#0");
                this.hfVat.Value = dto.P_VAT.ToString("#####.#0");
                this.hfTax.Value = dto.P_Tax.ToString("#####.#0");
                this.txtDiscount.Text = dto.P_Discount.ToString("#####.#0");
                // default Quantity has 1
                this.txtQuantity.Text = "1";
                this.txtQuantity.Focus();
                // set focus in Quantity Text Field
                ScriptManager1.SetFocus(txtQuantity);
            }
            else
            {
                this.lblErrorMessage.Text = "Product Not Available. Please Insert Correct Product ID.";
                this.txtProduct.Text = "";
                this.txtProductName.Text = "";
                this.txtRate.Text = "";
                this.hfVat.Value = "";
                this.hfTax.Value = "";
                this.hfVat.Value = "";
                this.hfTax.Value = "";
                this.txtDiscount.Text = "";
                this.txtQuantity.Text = "0";
                this.txtProduct.Focus();
                ScriptManager1.SetFocus(txtProduct);
                return;
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {

        }
 
    }
   
}
