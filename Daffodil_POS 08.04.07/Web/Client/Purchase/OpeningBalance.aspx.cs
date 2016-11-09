using System;
using System.Data;
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

public partial class Client_Purchase_OpeningBalance : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                this.ddlProductName.Focus();
                this.ddlProductName.Attributes.Add("onkeypress", "clickbtn('" + btnProduct.ClientID + "')");
                this.txtOpeningDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtOpeningQty.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtOpeningRate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtOpeningDiscount.Attributes.Add("onkeypress", "FocusControl_byEnter()");

                // fill drop down list
                Facade facade = Facade.GetInstance();
                DropDownListProduct(facade);
                
                DataSet ds = new DataSet();
                ds = facade.createOpeningBalanceBL().getDataSetOpeningBalanceInfo();
                //this.GridView1.DataSource = ds.Tables("OpeningBalance").DefaultView;
                //this.GridView1.DataBind();

            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }

        }
    }

    private void DropDownListProduct(Facade facade)
    {
        IProductInfoBL oIProductInfoBL = facade.GetProductInfoInstance();
        List<ProductInfoDTO> oCategoryList = oIProductInfoBL.GetProductInfo();

        int i = 0;
        ddlProductName.Items.Clear();
        ddlProductName.Items.Add("(Select any product)");
        this.ddlProductName.Items[i].Value = "";
        foreach (ProductInfoDTO newDto in oCategoryList)
        {
            i++;
            this.ddlProductName.Items.Add(newDto.P_Name);
            this.ddlProductName.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }

        if (this.ddlProductName.SelectedValue == "")
        {
            this.lblErrorMessage.Text = "Select a Supplier Name";
            return;
        }
        try
        {
            OpeningBalanceDTO oOpeningBalanceDTO = Populate();
            
            Facade facade = Facade.GetInstance();
            IOpeningBalanceBL oOpeningBalanceBL = facade.createOpeningBalanceBL();
            oOpeningBalanceBL.addNewOpeningRecord(oOpeningBalanceDTO);

            this.lblErrorMessage.Text = "Data Save Successfully.";

            this.ddlProductName.SelectedValue = "";
            this.txtHideFieldPK.Value = "";
            this.txtOpeningDate.Text = "";
            this.txtOpeningQty.Text="";
            this.txtOpeningRate.Text = "";
            this.txtOpeningDiscount.Text = "";
            this.btnSave.Text = "Save";
            this.GridView1.DataBind();

        }
        catch (Exception Exp)
        {
            this.lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    private OpeningBalanceDTO Populate()
    {
        try
        {
            string strP_PK;
            OpeningBalanceDTO dto = new OpeningBalanceDTO();

            if (this.txtHideFieldPK.Value != "")
            {
                dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value);
            }
            Guid nullGuid = Guid.NewGuid();
            nullGuid = (Guid)TypeDescriptor.GetConverter(nullGuid).ConvertFromString("00000000-0000-0000-0000-000000000000");

            strP_PK = (string)this.ddlProductName.SelectedValue;
            dto.P_PK = strP_PK == string.Empty ? nullGuid : (Guid)TypeDescriptor.GetConverter(dto.P_PK).ConvertFromString(strP_PK);
            dto.OpeningDate = Convert.ToDateTime(this.txtOpeningDate.Text);
            dto.OpeningQty = this.txtOpeningQty.Text == string.Empty ? 0 : (decimal)TypeDescriptor.GetConverter(dto.OpeningQty).ConvertFromString(this.txtOpeningQty.Text);
            dto.OpeningRate = this.txtOpeningRate.Text == string.Empty ? 0 : (decimal)TypeDescriptor.GetConverter(dto.OpeningRate).ConvertFromString(this.txtOpeningRate.Text);
            dto.OpeningDiscount = this.txtOpeningDiscount.Text == string.Empty ? 0 : (decimal)TypeDescriptor.GetConverter(dto.OpeningDiscount).ConvertFromString(this.txtOpeningDiscount.Text);
            dto.EntryBy = "Admin";
            dto.EntryDate = DateTime.Now.Date;
            return dto;
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Client/Purchase/Default.aspx");
    }
    protected void btnProduct_Click(object sender, EventArgs e)
    {
        try
        {
            
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
                this.txtOpeningQty.Text = "1";
                this.txtOpeningRate.Text = oProductInfoDTO.P_CostPrice.ToString("####.##");
                this.txtOpeningDiscount.Text = oProductInfoDTO.P_Discount.ToString("####.##"); 
                this.hfProductCode.Value = oProductInfoDTO.P_Code;
                this.HiddenField1.Value = oProductInfoDTO.PrimaryKey.ToString();
                
                
            }

        }
        catch (Exception exp)
        {
            lblErrorMessage.Text = cls.ErrorString(exp);
        }
        finally
        {
            ScriptManager1.SetFocus(txtOpeningDate);
        }

    }
}
