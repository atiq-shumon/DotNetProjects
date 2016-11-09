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

public partial class ui_setup_ProductSubCategoryInfo : System.Web.UI.Page
{
    
    ClsErrorHandle cls = new ClsErrorHandle();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.ddlProductCategory.Focus();
        this.ddlProductCategory.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtPSubCategoryDescription.Attributes.Add("onkeypress", "FocusControl_byEnter()");

        if (!IsPostBack)
        {
            try
            {
                Facade facade = Facade.GetInstance();

                DropDownListCategory(facade);
            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }
        }        
    }

    private void DropDownListCategory(Facade facade)
    {
        IProductCategoryBL categoryList = facade.createProductCategoryBL();
        List<ProductCategoryInfoDTO> oCategoryList = categoryList.showData();
        
        int i = 0;
        ddlProductCategory.Items.Clear();
        ddlProductCategory.Items.Add("(Select any category)");
        this.ddlProductCategory.Items[i].Value = "";
        foreach (ProductCategoryInfoDTO newDto in oCategoryList)
        {
            i++;
            this.ddlProductCategory.Items.Add(newDto.PC_Description);
            this.ddlProductCategory.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lblErrorMessage.Text.Length != 0)
            {
                this.lblErrorMessage.Text = "";
            }

            ProductSubCategoryInfoDTO dto = populate();

            Facade facade = Facade.GetInstance();
            IProductSubCategoryInfoBL oCategoryBL = facade.createProductSubCategoryBL();
            oCategoryBL.addNewProductSubCategory(dto);

            this.lblErrorMessage.Text = "Data Save Successfully.";

            this.GridView1.DataBind();
            
            
            this.txtHideFieldPK.Value = "";
            this.txtPSCCode.Text  = "";
            this.txtPSubCategoryDescription.Text  = "";            
            this.ddlProductCategory.SelectedValue = "";
            this.btnSave.Text = "Save";
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }
    /// <summary>
    /// Set All Information in Domain Class
    /// </summary>
    /// <returns></returns>
    public ProductSubCategoryInfoDTO  populate()
    {
        try
        {
            string strPC_PK;
            ProductSubCategoryInfoDTO dto = new ProductSubCategoryInfoDTO();
            // populate dto

            if (this.txtHideFieldPK.Value != "")
            {
                dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value);
            }

            if (this.ddlProductCategory.SelectedValue == "00000000-0000-0000-0000-000000000000")
            {
                throw new Exception("Invalid category.");
            }
            
            dto.PSC_Description = this.txtPSubCategoryDescription.Text;
            strPC_PK = (string)this.ddlProductCategory.SelectedValue;
            dto.PC_PK = (Guid)TypeDescriptor.GetConverter(dto.PC_PK).ConvertFromString(strPC_PK);
            dto.EntryBy = "Admin";
            dto.EntryDate = DateTime.Now.Date;

            return dto;
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
    }

    protected void GridView1_BeforeEdting(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;

    }

    protected void GridView1_RowEdting(object sender, GridViewCommandEventArgs e)
    {
        try
        {

            if (e.CommandName == "Edit")
            {
                
                Facade facade = Facade.GetInstance();
                int index = Convert.ToInt32(e.CommandArgument);
                
                ProductSubCategoryInfoDTO oProductSubCategoryInfoDTO = new ProductSubCategoryInfoDTO();
                
                GridViewRow row = GridView1.Rows[index];

                DataKey xx = this.GridView1.DataKeys[index];
                this.txtHideFieldPK.Value = xx.Value.ToString();

                oProductSubCategoryInfoDTO = facade.GetProductsubCategoryInfo((Guid)TypeDescriptor.GetConverter(oProductSubCategoryInfoDTO.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value));

                this.txtPSCCode.Text = Server.HtmlDecode(row.Cells[2].Text);
                this.txtPSubCategoryDescription.Text = Server.HtmlDecode(row.Cells[3].Text);
                this.btnSave.Text = "Update";
                
                ProductCategoryInfoDTO pcDto = new ProductCategoryInfoDTO();
                pcDto = facade.GetProductCategoryInfo((Guid)oProductSubCategoryInfoDTO.PC_PK);
                this.ddlProductCategory.SelectedValue = pcDto.PrimaryKey.ToString();

                //*********Modified by NERO. DDL Select Example. Req: SAMAD********************
                //DropDownList1.SelectedItem.Selected = false;
                //DropDownList1.Items.FindByValue("000111-222556-3333-2222-222").Selected=true;
                //*********END EXAMPLE*********************************************************

            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //try
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        Button b = (Button)e.Row.FindControl("Button1");
        //        b.Attributes.Add("onclick", "javascript:return " +
        //        "confirm('Are you sure you want to delete this record " +
        //        DataBinder.Eval(e.Row.DataItem, "PSC_Code") + "')");
        //    }
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Default.aspx");
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        lblErrorMessage.Text = "Data Deleted Successfully";
    }
}
