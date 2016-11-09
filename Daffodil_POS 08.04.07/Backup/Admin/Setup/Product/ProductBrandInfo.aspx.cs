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
using System.Drawing;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;

public partial class ui_setup_ProductBrandInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    public string PrimaryKey;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.txtBrandName.Focus();
        this.txtBrandName.Attributes.Add("onkeypress", "FocusControl_byEnter()");

    }
    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }

        if (this.txtBrandName.Text.Length == 0)
        {
            this.lblErrorMessage.Text = "* Invalid Brand Name";
            return;
        }
        
        ProductBrandInfoDTO pbDto = Populate();

        try
        {
            IProductBrandBL pbFacade = Facade.GetInstance().GetPBBlImp();
            pbFacade.AddProductBrand(pbDto);

            this.lblErrorMessage.Text = "Data Save Successfully.";

            this.hfPrimaryKey.Value = "";
            this.txtBrandCode.Text = "";
            this.txtBrandName.Text = "";
            this.btnAdd.Text = "Save";
            GridView1.DataBind();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
        
    }
    /// <summary>
    /// Set all information in Domain Object
    /// </summary>
    /// <returns></returns>
    private ProductBrandInfoDTO Populate()
    {
        try
        {
            ProductBrandInfoDTO pbDto = new ProductBrandInfoDTO();
            if (this.hfPrimaryKey.Value.ToString() != "")
            {
                pbDto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(pbDto.PrimaryKey).ConvertFromString(this.hfPrimaryKey.Value);
            }

            pbDto.PB_Code = this.txtBrandCode.Text;
            pbDto.PB_Name = this.txtBrandName.Text;
            pbDto.EntryBy = Constants.DEFULT_USER;
            pbDto.EntryDate = DateTime.Today;

            return pbDto;
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
    }
     
    protected void GridView1_RowEditing(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                this.txtBrandCode.Text = Server.HtmlDecode(row.Cells[1].Text);
                this.txtBrandName.Text = Server.HtmlDecode(row.Cells[2].Text);

                DataKey dk = GridView1.DataKeys[index];
                this.hfPrimaryKey.Value = dk.Value.ToString();
                this.btnAdd.Text = "Update";
            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    try
        //    {
        //        Button b = (Button)e.Row.FindControl("Button1");
        //        b.Attributes.Add("onclick", "javascript:return " +
        //        "confirm('Are you sure you want to delete this record " +
        //        DataBinder.Eval(e.Row.DataItem, "PB_Code") + "')");
        //    }
        //    catch (Exception Exp)
        //    {
        //        lblErrorMessage.Text = cls.ErrorString(Exp);
        //    }
        //}
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int index = e.RowIndex;
            GridViewRow row = GridView1.Rows[index];

            ProductBrandInfoDTO pbDto = new ProductBrandInfoDTO();

            DataKey dk = GridView1.DataKeys[index];
            this.hfPrimaryKey.Value = dk.Value.ToString();
            pbDto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(pbDto.PrimaryKey).ConvertFromString(this.hfPrimaryKey.Value);

            IProductBrandBL pbFacade = Facade.GetInstance().GetPBBlImp();
            pbFacade.DelProductBrand(pbDto);
            this.hfPrimaryKey.Value = "";
            GridView1.DataBind();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }
    
    protected void GridView1_BeforeEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
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
