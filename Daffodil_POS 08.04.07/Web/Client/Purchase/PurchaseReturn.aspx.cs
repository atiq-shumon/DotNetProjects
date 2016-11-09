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
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;
using DSL.POS.BusinessLogicLayer.Imp;

public partial class Client_Purchase_PurchaseReturn : System.Web.UI.Page
{
    protected DataTable myDt;
    Guid guidPurchaseMain_Pk_Code = new Guid();
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["purchaseuserrolename"]))
            {
                Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
            }
            try
            {
                this.txtGRNNo.Focus();

                this.txtGRNNo.Attributes.Add("onkeypress","clickbtn('" + btnClickGRNNo.ClientID+"')");
                this.ddlSupplierCode.Attributes.Add("onkeypress", "clickbtn('" + btnClickSupplierCode.ClientID + "')");
                this.ddlProductName.Attributes.Add("onkeypress", "clickbtn('" + btnClickPurductName.ClientID + "')");
                this.txtRemarks.Attributes.Add("onkeypress", "clickbtn('" + btnAdd.ClientID + "')");

                this.txtRefno.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtGRNDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtGRNDate.Attributes.Add("onKeyUp", "formatDateField()");

                this.txtQuantity.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtQuantity.Attributes.Add("onKeyUp", "Product_Price()");

                this.txtDiscoutInd.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtDiscoutInd.Attributes.Add("onKeyUp", "Product_Price()");

                this.txtUnitPrice.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                //this.txtAmount.Attributes.Add("onkeypress", "FocusControl_byEnter()");        
                this.txtDeduction.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtReturnAmount.Attributes.Add("onKeyUp", "CalculateNetPayable()");

                // fill drop down list
                Facade facade = Facade.GetInstance();
                DropDownListSupplier(facade);
                DropDownListProduct(facade);

                // Create a New Table and keep in Session
                CreateTableInSession();
            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }
        }

    }
    /// All Method available here
    # region All Method

    /// <summary>
    /// Create a New Table & Keep in Session
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
        DataTable myDataTable = new DataTable();

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

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "Remarks";
        myDataTable.Columns.Add(myDataColumn);


        return myDataTable;
    }

    /// <summary>
    /// Add New Raw in Table
    /// </summary>
    /// <param name="ProductCode">string</param>
    /// <param name="strProductName">string</param>
    /// <param name="quantity">string</param>
    /// <param name="rate">string</param>
    /// <param name="discount">string</param>
    /// <param name="Amount">string</param>
    /// <param name="P_PK">string</param>
    /// <param name="remarks">string</param>
    /// <param name="myTable">DataTable</param>
    private void AddDataToTable(string ProductCode,
                                string strProductName,
                                string quantity,
                                string rate,
                                string discount,
                                string Amount,
                                string P_PK,
                                string remarks,
                                DataTable myTable)
    {
        try
        {
            DataRow row;
            row = myTable.NewRow();
            row["Product Code"] = ProductCode;
            row["Product Name"] = strProductName;
            row["Quantity"] = quantity;
            row["Rate"] = rate;
            row["Discount"] = discount;
            row["Total Amount"] = (((this.txtUnitPrice.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtUnitPrice.Text)) *
                                       Convert.ToDecimal(quantity)) - (this.txtDiscoutInd.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscoutInd.Text)));
            Guid p_pk = new Guid(P_PK);
            row["PK"] = p_pk;
            row["Remarks"] = remarks;
            myTable.Rows.Add(row);
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    /// <summary>
    /// Update Product rate & discount
    /// </summary>
    protected void Update_Product()
    {
        try
        {
            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = new SqlCommand();
            objCmd.CommandText = "Update ProductInfo Set P_CostPrice=@P_CostPrice,P_Discount=@P_Discount,EntryBy=@EntryBy,EntryDate=@EntryDate Where P_PK=@P_PK";
            objCmd.Parameters.Add(new SqlParameter("@P_PK", SqlDbType.UniqueIdentifier, 16));
            objCmd.Parameters.Add(new SqlParameter("@P_CostPrice", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@P_Discount", SqlDbType.Decimal, 9));
            objCmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 6));
            objCmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime, 8));
            Guid productguid = Guid.NewGuid();
            productguid = ((Guid)TypeDescriptor.GetConverter(productguid).ConvertFromString(this.ddlProductName.SelectedValue));
            objCmd.Parameters["@P_PK"].Value = productguid;
            objCmd.Parameters["@P_CostPrice"].Value = this.txtUnitPrice.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtUnitPrice.Text);
            objCmd.Parameters["@P_Discount"].Value = this.txtDiscoutInd.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscoutInd.Text);
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
    /// Get Data for table when user want to insert new one or update existing one
    /// </summary>
    protected void Get_Data_In_Table()
    {
        try
        {
            int count = 0;
            int rowNo = 0;
            int totalRows = 0;


            if (this.ddlProductName.SelectedValue == "")
            {
                throw new Exception("Invalid Product Selected.");
            }
            else if (txtQuantity.Text.Trim() == "")
            {
                this.lblErrorMessage.Text = "You must fill a Quantity.";
                return;
            }
            else if (txtUnitPrice.Text.Trim() == "")
            {
                this.lblErrorMessage.Text = "You must fill a Unit Price.";
                return;
            }
            else
            {
                this.lblErrorMessage.Text = "";

                DataTable myDataTable = new DataTable();
                myDataTable = ((DataTable)Session["myDatatable"]);
                totalRows = myDataTable.Rows.Count;

                for (rowNo = 0; rowNo < totalRows; rowNo++)
                {
                    if (this.hfPrimaryKey.Value != "")
                    {
                        if (Convert.ToString(this.hfPrimaryKey.Value) == myDataTable.Rows[rowNo][6].ToString())
                        {
                            myDataTable.Rows[rowNo][0] = this.hfProductCode.Value.ToString();
                            myDataTable.Rows[rowNo][1] = this.ddlProductName.SelectedItem.ToString();
                            myDataTable.Rows[rowNo][2] = this.txtQuantity.Text;
                            myDataTable.Rows[rowNo][3] = this.txtUnitPrice.Text;
                            myDataTable.Rows[rowNo][4] = this.txtDiscoutInd.Text;
                            myDataTable.Rows[rowNo][5] = this.txtAmount.Text;
                            myDataTable.Rows[rowNo][5] = ((this.txtUnitPrice.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtUnitPrice.Text)) *
                                                    (this.txtQuantity.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text))) -
                                                    ((this.txtDiscoutInd.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscoutInd.Text)) *
                                                    (this.txtQuantity.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text)));

                            myDataTable.Rows[rowNo][6] = this.hfPrimaryKey.Value.ToString();
                            myDataTable.Rows[rowNo][7] = this.txtRemarks.Text;

                            count = 1;
                            this.hfPrimaryKey.Value = "";
                            this.hfProductCode.Value = "";
                            this.btnAdd.Text = "Add";
                            break;
                        }

                        else
                            count = 0;
                    }
                    else if (this.ddlProductName.SelectedItem.ToString().Trim() == myDataTable.Rows[rowNo][1].ToString())
                    {
                        string addQuantity;
                        decimal totalQuantity = 0;

                        addQuantity = myDataTable.Rows[rowNo][2].ToString();
                        totalQuantity = (this.txtQuantity.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text)) + Convert.ToDecimal(addQuantity);

                        myDataTable.Rows[rowNo][2] = totalQuantity.ToString();

                        myDataTable.Rows[rowNo][6] = this.HiddenField1.Value.ToString();
                        myDataTable.Rows[rowNo][5] = this.txtAmount.Text;
                        myDataTable.Rows[rowNo][5] = ((this.txtUnitPrice.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtUnitPrice.Text)) *
                                          totalQuantity) - ((this.txtDiscoutInd.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscoutInd.Text)) * totalQuantity);
                        count = 1;
                        this.HiddenField1.Value = "";
                        this.btnAdd.Text = "Add";
                        break;
                    }
                    else
                        count = 0;
                }

                if (count == 0)
                {
                    AddDataToTable(this.hfProductCode.Value.ToString(),
                        this.ddlProductName.SelectedItem.ToString().Trim(),
                        this.txtQuantity.Text.Trim(),
                        this.txtUnitPrice.Text.Trim(),
                        this.txtDiscoutInd.Text.Trim(),
                        this.txtAmount.Text.Trim(),
                        this.HiddenField1.Value.ToString(),
                        this.txtRemarks.Text.Trim(),
                        (DataTable)Session["myDatatable"]);
                }

                this.GridView1.DataSource = ((DataTable)Session["myDatatable"]).DefaultView;
                this.GridView1.DataBind();

                //clear input texts

                this.ddlProductName.SelectedValue = "";
                this.txtQuantity.Text = "";
                this.txtUnitPrice.Text = "";
                this.txtDiscoutInd.Text = "";
                this.txtQuantity.Text = "";
                this.hfProductCode.Value = "";
                this.txtAmount.Text = "";
                this.txtRemarks.Text = "";
                this.HiddenField1.Value = "";
                this.hfPrimaryKey.Value = "";

            }

        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            this.txtGroseTotal.Text = GetTotalAmount().ToString("#####.#0");
            this.txtReturnAmount.Text = GetTotalAmount().ToString("#####.#0");
            //this.txtTotalDiscount.Focus();

        }
    }

    /// <summary>
    /// Get Total Amount all entery product
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
            totalAmount = totalAmount + Convert.ToDecimal(myDataTable.Rows[rowNo][5]);
        }

        return totalAmount;
    }
    # endregion
    private void DropDownListSupplier(Facade facade)
    {
        ISupplierInfoBL oISupplierInfoBL = facade.createSupplierBL();
        List<SupplierInfoDTO> oSupplierList = oISupplierInfoBL.showDataSupplierInfo();

        int i = 0;
        ddlSupplierCode.Items.Clear();
        ddlSupplierCode.Items.Add("(Select any Supplier)");
        this.ddlSupplierCode.Items[i].Value = "";
        foreach (SupplierInfoDTO newDto in oSupplierList)
        {
            i++;
            this.ddlSupplierCode.Items.Add(newDto.SupplierName);
            this.ddlSupplierCode.Items[i].Value = newDto.PrimaryKey.ToString();
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.ddlProductName.SelectedValue == "")
            {
                return;
            }
            this.Update_Product();
            this.Get_Data_In_Table();
        }
        catch (Exception exp)
        {
            lblErrorMessage.Text = cls.ErrorString(exp);
        }
        finally
        {
            ScriptManager1.SetFocus(ddlProductName);
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

                Facade facade = Facade.GetInstance();

                DataKey xx = this.GridView1.DataKeys[index];

                this.ddlProductName.SelectedValue = xx.Value.ToString();

                this.txtQuantity.Text = Server.HtmlDecode(row.Cells[4].Text);
                this.txtUnitPrice.Text = Server.HtmlDecode(row.Cells[5].Text);
                this.txtDiscoutInd.Text = Server.HtmlDecode(row.Cells[6].Text);
                this.txtAmount.Text = Server.HtmlDecode(row.Cells[7].Text);
                this.txtRemarks.Text = Server.HtmlDecode(row.Cells[9].Text);
                this.btnAdd.Text = "Update";
                this.hfProductCode.Value = Server.HtmlDecode(row.Cells[2].Text);
                this.hfPrimaryKey.Value = xx.Value.ToString();

            }
            if (e.CommandName == "Delete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                this.hfPrimaryKey.Value = row.Cells[2].Text;

                myDataTable = ((DataTable)Session["myDatatable"]);
                totalRows = myDataTable.Rows.Count;

                for (rowNo = 0; rowNo < totalRows; rowNo++)
                {
                    if (Convert.ToString(hfPrimaryKey.Value) == (string)myDataTable.Rows[rowNo][0])
                    {
                        myDataTable.Rows.RemoveAt(rowNo);
                        break;
                    }
                }

                this.GridView1.DataSource = ((DataTable)Session["myDatatable"]).DefaultView;
                this.GridView1.DataBind();

                this.txtGroseTotal.Text = GetTotalAmount().ToString("#####.#0");
                this.txtReturnAmount.Text = GetTotalAmount().ToString("#####.#0");
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //LabelDocument lblBarcode = new LabelDocument();
        //int intBQty=0 ; 
        //string  strBarCodeVal = "" ;
        //string  strBarHeading = "";
        //LabelField  lblFields ;
        //LabelField  lblField ;
        if (this.ddlSupplierCode.SelectedValue == "")
        {
            this.lblErrorMessage.Text = "Select a Supplier Name";
            return;
        }

        try
        {
            DataTable myDataTable = new DataTable();
            myDataTable = ((DataTable)Session["myDatatable"]);

            PurchaseReturnMainDTO  dto = populate(myDataTable);

            Facade facade = Facade.GetInstance();
            IPurchaseReturnInfoBL oIPurchaseReturnInfoBL = facade.createPurchaseReturnBL();
            oIPurchaseReturnInfoBL.addNewPurchaseReturnInfo(dto);

            lblErrorMessage.Text = "Data Save Successfully.";
            this.GridView1.DataBind();

            //================Clear All Text Box and Grid View====================
            this.hfPrimaryKey.Value = "";
            this.hfProductCode.Value = "";
            this.HiddenField1.Value = "";
            this.hfGRNNo.Value = "";
            this.ddlSupplierCode.SelectedValue = "";
            this.txtRefno.Text = "";
            this.txtGRNDate.Text = "";
            this.txtRemarks.Text = "";
            this.txtSupplierAddress.Text = "";
            this.txtGRNNo.Text = "";
            this.txtDeduction.Text = "";
            this.txtUnitPrice.Text = "";
            this.txtQuantity.Text = "";
            this.txtGroseTotal.Text = "";
            this.txtReturnAmount.Text = "";
            //this.txtPurchaseId.Text = "";
            this.txtCurrentBalance.Text = "";
            this.txtRemarks.Text = "";

            myDataTable.Clear();
            myDataTable.Reset();
            //myDataTable.Rows.Remove();

            this.GridView1.DataSource = myDataTable.DefaultView;
            this.GridView1.DataBind();

            // Create a New Session and Table
            CreateTableInSession();

            //====================================================================

        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }

    }
    /// <summary>
    /// set up Purchase Main and Sub DTO
    /// </summary>
    /// <returns>PurchaseMainDTO</returns>
    public PurchaseReturnMainDTO populate(DataTable myDataTable)
    {

        PurchaseReturnMainDTO oPurchaseReturnMainDTO = new PurchaseReturnMainDTO();
        List<PurchaseReturnSubDTO> lPurchaseReturnSubDTO = new List<PurchaseReturnSubDTO>();
        int rowNo = 0;
        int totalRows = 0;

        try
        {

            //Guid SupplierP_PK = new Guid(this.hfSupplierPrimaryKey.Value.ToString());

            //DataTable myDataTable = new DataTable();            

            guidPurchaseMain_Pk_Code = Guid.NewGuid();

            oPurchaseReturnMainDTO.PrimaryKey = guidPurchaseMain_Pk_Code;

            if ((this.hfSupplierPrimaryKey.Value.ToString()) == "")
            {
                oPurchaseReturnMainDTO.Sp_PK = new Guid("00000000-0000-0000-0000-000000000000");
            }
            else
                oPurchaseReturnMainDTO.Sp_PK = new Guid(this.hfSupplierPrimaryKey.Value.ToString()); ;

            if (this.txtGRNNo.Text.Length != 0)
                oPurchaseReturnMainDTO.GRN_No = this.txtGRNNo.Text;
            else
                oPurchaseReturnMainDTO.GRN_No = "";


            oPurchaseReturnMainDTO.GRNDate = Convert.ToDateTime(this.txtGRNDate.Text);
            oPurchaseReturnMainDTO.ReferenceNo = this.txtRefno.Text;
            oPurchaseReturnMainDTO.TotalReturnAmount = Decimal.Parse(this.txtGroseTotal.Text);

            if (this.txtDeduction.Text.Length != 0)
                oPurchaseReturnMainDTO.PurchaseDeduction = Decimal.Parse(this.txtDeduction.Text);
            else
                oPurchaseReturnMainDTO.PurchaseDeduction= 0;

            //================================Get Data From Table/GridView for SalesSub=====================


            //myDataTable = ((DataTable)Session["myDatatable"]);
            totalRows = myDataTable.Rows.Count;

            // set up in Purchase Sub Info from Data Table.
            for (rowNo = 0; rowNo < totalRows; rowNo++)
            { 
                PurchaseReturnSubDTO oPurchaseReturnSubDTO = SetPurchaseReturnSubDTO(rowNo, guidPurchaseMain_Pk_Code, myDataTable);
                lPurchaseReturnSubDTO.Add(oPurchaseReturnSubDTO);
            }

            oPurchaseReturnMainDTO.PurchaseReturnSubDTO = lPurchaseReturnSubDTO;
            oPurchaseReturnMainDTO.EntryBy = User.Identity.Name;

            //====================================================================================

        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        return oPurchaseReturnMainDTO;
    }

    /// <summary>
    /// set up in Purchase Sub DTO
    /// </summary>
    /// <param name="rowNo">int </param>
    /// <param name="guidPurchaseMain_Pk_Code">Guid</param>
    /// <param name="myDataTable">DataTable</param>
    /// <returns>PurchaseSubDTO</returns>
    protected PurchaseReturnSubDTO SetPurchaseReturnSubDTO(int rowNo, Guid guidPurchaseMain_Pk_Code, DataTable myDataTable)
    {
        PurchaseReturnSubDTO dto = new PurchaseReturnSubDTO();

        dto.P_PK = (Guid)myDataTable.Rows[rowNo][6];
        dto.PRM_PK = guidPurchaseMain_Pk_Code;
        dto.ItemRate = Decimal.Parse(myDataTable.Rows[rowNo][3].ToString());
        dto.Notes = this.txtRemarks.Text;
        dto.Discount = Decimal.Parse(myDataTable.Rows[rowNo][4].ToString());
        dto.Notes = myDataTable.Rows[rowNo][7].ToString();
        dto.ReceivedQuantity = Decimal.Parse(myDataTable.Rows[rowNo][2].ToString());
        dto.EntryBy = User.Identity.Name;

        return dto;

    }
    /// <summary>
    /// Get Supplier Information Corresponding entered Supplier Code in TextBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClickSupplierCode_Click(object sender, EventArgs e)
    {
        try
        {
            if ((this.lblErrorMessage.Text.Length != 0) || (this.lblSuccessMessage.Text.Length != 0))
            {
                this.lblSuccessMessage.Text = "";
                this.lblErrorMessage.Text = "";
            }

            SupplierInfoDTO dto = new SupplierInfoDTO();

            if (this.ddlSupplierCode.SelectedValue == "")
            {
                return;
            }

            Facade facade = Facade.GetInstance();
            dto = facade.getSupplierInfo((Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.ddlSupplierCode.SelectedValue));
            //dto = facade.getSupplierInfoByCode(strSupplierCode);

            this.hfSupplierPrimaryKey.Value = dto.PrimaryKey.ToString();

            if (this.hfSupplierPrimaryKey.Value != "00000000-0000-0000-0000-000000000000")
            {
                this.ddlSupplierCode.DataTextField = dto.SupplierName;
                this.txtSupplierAddress.Text = dto.Address;
            }
            else
            {
                this.lblErrorMessage.Text = "Supplier Not Available. Please Insert Correct Supplier ID.";
                this.ddlSupplierCode.SelectedValue = "";
                //this.txtSupplierName.Text = "";
                this.txtSupplierAddress.Text = "";
                this.ddlSupplierCode.Focus();
                return;
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            ScriptManager1.SetFocus(txtRefno);
        }
    }

    /// <summary>
    /// Get Product Information corresponding Selected Product from Drop Down List
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClickPurductName_Click(object sender, EventArgs e)
    {
        try
        {
            decimal totalAmount = 0;

            if ((this.lblErrorMessage.Text.Length != 0) || (this.lblSuccessMessage.Text.Length != 0))
            {
                this.lblSuccessMessage.Text = "";
                this.lblErrorMessage.Text = "";
            }

            if (this.ddlProductName.SelectedValue == "")
            {
                return;
            }

            ProductInfoDTO oProductInfoDTO = new ProductInfoDTO();

            Facade facade = Facade.GetInstance();

            if (this.ddlProductName.SelectedValue != "")
            {
                oProductInfoDTO = ProductInfoBLImp.LoadProductInfoDTO((Guid)TypeDescriptor.GetConverter(oProductInfoDTO.PrimaryKey).ConvertFromString(this.ddlProductName.SelectedValue));
                this.txtUnitPrice.Text = oProductInfoDTO.P_CostPrice.ToString();
                this.txtDiscoutInd.Text = oProductInfoDTO.P_Discount.ToString();
                this.hfProductCode.Value = oProductInfoDTO.P_Code;
                this.HiddenField1.Value = oProductInfoDTO.PrimaryKey.ToString();
                this.txtQuantity.Text = "1";
                totalAmount = ((this.txtQuantity.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtQuantity.Text)) *
                    (this.txtUnitPrice.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtUnitPrice.Text))) -
                    (this.txtDiscoutInd.Text == string.Empty ? 0 : Convert.ToDecimal(this.txtDiscoutInd.Text));

                this.txtAmount.Text = totalAmount.ToString();
            }

        }
        catch (Exception exp)
        {
            lblErrorMessage.Text = cls.ErrorString(exp);
        }
        finally
        {
            ScriptManager1.SetFocus(txtQuantity);
        }

    }

    /// <summary>
    /// Get Purchase Information corresponding GRN No.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClickGRNNo_Click(object sender, EventArgs e)
    {
        try
        {
            string strGRNNo = this.txtGRNNo.Text;
            if (strGRNNo.Length == 0)
            {
               return;
            }

            PurchaseMainDTO  dto = new PurchaseMainDTO();
            PurchaseReturnMainDTO reDto = new PurchaseReturnMainDTO();

            Facade facade = Facade.GetInstance();

    

            reDto = facade.GetPurchaseReturnInfoDTO(strGRNNo);
            // set up the member primary code in local declared Hidden field
            this.hfGRNNo.Value = reDto.PurchaseMainDTO.PrimaryKey.ToString();

            if (this.hfGRNNo.Value != "00000000-0000-0000-0000-000000000000")
            {
                this.lblErrorMessage.Text = "";
                pnlPurchaseRDate.Visible = true;
                pnlCurrentBalance.Visible = true;
            }
            else
            {
                pnlPurchaseRDate.Visible = false;
                pnlCurrentBalance.Visible = false;
                this.txtGRNNo.Text = "";
                this.lblErrorMessage.Text = "Purchase Not Available. Please Insert Correct GRN No.";
                return;
            }
            string strDate;
            this.hfSupplierPrimaryKey.Value = reDto.SupplierInfoDTO.PrimaryKey.ToString();
            strDate = Convert.ToString(reDto.PurchaseMainDTO.GRNDate);
            this.txtGRNDate.Text = strDate.Substring(0,10);
            this.ddlSupplierCode.SelectedValue = reDto.SupplierInfoDTO.PrimaryKey.ToString();
            this.txtSupplierAddress.Text = reDto.SupplierInfoDTO.Address;
            //this.txtDepositBalance.Text = reDto.MemberInfoDTO.CreditLimit.ToString();



            //this.GridView1.DataSource = ((DataTable)Session["myDatatable"]).DefaultView;
            //this.GridView1.DataBind();
            this.txtGRNNo.Focus();

        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        finally
        {
            if (this.txtGRNNo.Text.Length != 0)
            {
                ScriptManager1.SetFocus(ddlProductName);
            }
            else
            {
                ScriptManager1.SetFocus(ddlSupplierCode);
            }
            
        }

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}
