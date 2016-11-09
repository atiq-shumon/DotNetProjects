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

public partial class ui_setup_ProductCategoryInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.txtCategoryDescription.Focus();
        this.txtCategoryDescription.Attributes.Add("onkeypress", "FocusControl_byEnter()");


        if (!IsPostBack)
        {
            //btnSave.Attributes.Add("onClick", "test()");
            //ProductCategoryInfoDTO oProductCategoryInfoDTO = new ProductCategoryInfoDTO();

            //Facade facade = Facade.GetInstance();
            //IProductCategoryBL oIProductCategoryBL = facade.createProductCategoryBL();
            //List<ProductCategoryInfoDTO> oArrayList = oIProductCategoryBL.showData();
            //this.lblErrorMessage.Text = "******";
        }
    }

    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }


        ProductCategoryInfoDTO dto = populate();

        Facade facade = Facade.GetInstance();
        IProductCategoryBL oCategoryBL = facade.createProductCategoryBL();
        try
        {
            oCategoryBL.addNewProduct(dto);

           // this.lblErrorMessage.Text = "Data Save Successfully.";

            //=======================================================================
           // btnSave.Attributes.Add("onclick", "test()");
            
            //=======================================================================

            this.txtHideFieldPK.Value = "";
            this.txtProductCategoryCode.Text = "";
            this.txtCategoryDescription.Text = "";
            this.btnSave.Text = "Save";
            this.GridView1.DataBind();
            this.lblErrorMessage.Text = "Data Save Successfully.";
            
        }
        catch(Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    public ProductCategoryInfoDTO populate()
    {
        try
        {
            ProductCategoryInfoDTO dto = new ProductCategoryInfoDTO();
            // populate dto

            if (this.txtHideFieldPK.Value != "")
            {
                dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value);
            }

            dto.PC_Description = this.txtCategoryDescription.Text;
            dto.EntryBy = "Admin";
            dto.EntryDate = DateTime.Now.Date;

            return dto;
        }
        catch (Exception Exp)
        {
            throw Exp;
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
        //        DataBinder.Eval(e.Row.DataItem, "PC_Code") + "')");
        //    }
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
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

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                this.txtProductCategoryCode.Text = Server.HtmlDecode(row.Cells[1].Text);
                this.txtCategoryDescription.Text = Server.HtmlDecode(row.Cells[2].Text);
                
                DataKey xx = this.GridView1.DataKeys[index];

                this.txtHideFieldPK.Value = xx.Value.ToString();
                this.btnSave.Text = "Update";

            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Default.aspx");
    }
    protected void txtCategoryDescription_TextChanged(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        lblErrorMessage.Text = "Data Deleted Successfully";
    }
}
   
