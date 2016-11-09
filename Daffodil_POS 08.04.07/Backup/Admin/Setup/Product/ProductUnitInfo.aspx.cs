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
using System.Text;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;

public partial class ui_setup_ProductUnitInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.txtPU_Name.Focus();
        this.txtPU_Name.Attributes.Add("onkeypress", "FocusControl_byEnter()");
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //try
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        Button b = (Button)e.Row.FindControl("Button1");
        //        b.Attributes.Add("onclick", "javascript:return " +
        //        "confirm('Are you sure you want to delete product unit -> " +
        //        DataBinder.Eval(e.Row.DataItem, "PU_Name") + "')");
        //    }
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
    }
    protected void GridView1_RowEditing(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                this.txtPU_Code.Text = Server.HtmlDecode(row.Cells[1].Text);
                this.txtPU_Name.Text = Server.HtmlDecode(row.Cells[2].Text);
                DataKey dk = GridView1.DataKeys[index];

                this.txtPU_PK.Value = dk.Value.ToString();
                this.btnAdd.Text = "Update";

            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //try
        //{
        //    int index = e.RowIndex;
        //    GridViewRow row = GridView1.Rows[index];

        //    ProductUnitInfoDTO pudto = new ProductUnitInfoDTO();

        //    DataKey dk = GridView1.DataKeys[index];
        //    this.txtPU_PK.Value = dk.Value.ToString();
        //    pudto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(pudto.PrimaryKey).ConvertFromString(this.txtPU_PK.Value);

        //    IProductUnitBL puFacade = Facade.GetInstance().GetPUBLImp();
        //    puFacade.deleteProductUnit(pudto);

        //    this.txtPU_PK.Value = "";
        //    GridView1.DataBind();
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
    }

    protected void GridView1_BeforeEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lblErrorMessage.Text.Length != 0)
            {
                this.lblErrorMessage.Text = "";
            }

            if (this.txtPU_Name.Text.Length == 0)
            {
                this.lblErrorMessage.Text = "Unit Name field can not be blank. Please Insert";
                txtPU_Name.Focus();
                return;
            }
            ProductUnitInfoDTO pudto = Populate();

            IProductUnitBL puFacade = Facade.GetInstance().GetPUBLImp();
            puFacade.addNewProductUnit(pudto);

            this.lblErrorMessage.Text = "Data Save Successfully.";
            
            this.txtPU_PK.Value = "";
            this.txtPU_Code.Text = "";
            //this.txtPU_Code.Text = pudto.PU_Code;
            this.txtPU_Name.Text = "";
            this.btnAdd.Text = "Save";
            GridView1.DataBind();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    private ProductUnitInfoDTO Populate()
    {
        try
        {
            ProductUnitInfoDTO dto = new ProductUnitInfoDTO();
            if (this.txtPU_PK.Value.ToString() != "")
            { dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtPU_PK.Value); }

            dto.PU_Code = this.txtPU_Code.Text;
            dto.PU_Name = this.txtPU_Name.Text;
            dto.EntryBy = Constants.DEFULT_USER;
            dto.EntryDate = DateTime.Today;
            return dto;
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        try
        {
            Session["PrintGridviewColumns"] = this.GridView1.Columns;
            Session["PrintGridViewDataSource"] = this.ObjectDataSource1.Select();
            //Do some java script to bring up the Printing form in a different browser window
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append(Environment.NewLine);
            sb.Append("window.open(\"PrintGridview.aspx\",\"Print\",\"top=5,left=5\");");
            sb.Append(Environment.NewLine);
            sb.Append("</script>");

            ClientScript.RegisterStartupScript(this.GetType(), "print", sb.ToString());
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
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
