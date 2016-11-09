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
using System.ComponentModel;
using DSL.POS.DTO.DTO;
using DSL.POS.Facade;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;

public partial class ui_setup_SupplierInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.txtShortName.Focus();
        this.txtShortName.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtSupplierName.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtAddress.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtContractPerson.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtPhone.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtFax.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtEmail.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtWebAddress.Attributes.Add("onkeypress", "FocusControl_byEnter()");
    }

    protected void btnSave_Click(object sender, EventArgs e)    
    {
        try
        {
            if (this.lblErrorMessage.Text.Length != 0)
            {
                this.lblErrorMessage.Text = "";
            }

            SupplierInfoDTO dto = populate();

            Facade facade = Facade.GetInstance();
            ISupplierInfoBL oISupplierInfoBL = facade.createSupplierBL();
            oISupplierInfoBL.addNewSupplierRecord(dto);

            this.lblErrorMessage.Text = "Data Save Successfully.";

            this.txtHideFieldPK.Value = "";
            this.txtSupplierCode.Text = "";
            this.txtSupplierName.Text = "";
            this.txtShortName.Text = "";
            this.txtPhone.Text = "";
            this.txtFax.Text = "";
            this.txtEmail.Text = "";
            this.txtContractPerson.Text = "";
            this.txtAddress.Text = "";
            this.txtWebAddress.Text = "";
            this.btnSave.Text = "Save";

            this.GridView1.DataBind();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    public SupplierInfoDTO populate()
    {
        try
        {
            //string strPC_PK;
            SupplierInfoDTO dto = new SupplierInfoDTO();
            // populate dto


            if (this.txtHideFieldPK.Value != "")
            {
                dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value);
            }

            dto.SupplierName = this.txtSupplierName.Text;
            dto.ContractPerson = this.txtContractPerson.Text;
            dto.ShortName = this.txtShortName.Text;
            dto.Address = this.txtAddress.Text;
            dto.Phone = this.txtPhone.Text;
            dto.Fax = this.txtFax.Text;
            dto.Email = this.txtEmail.Text;
            dto.WebAddress = this.txtWebAddress.Text;
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
                SupplierInfoDTO oSupplierInfoDTO = new SupplierInfoDTO();

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView1.Rows[index];
                this.txtSupplierName.Text = Server.HtmlDecode(row.Cells[2].Text);

                DataKey xx = this.GridView1.DataKeys[index];
                this.txtHideFieldPK.Value = xx.Value.ToString();

                Facade facade = Facade.GetInstance();
                oSupplierInfoDTO = facade.getSupplierInfo((Guid)TypeDescriptor.GetConverter(oSupplierInfoDTO.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value));

                txtSupplierCode.Text = oSupplierInfoDTO.SupplierCode;
                txtSupplierName.Text = oSupplierInfoDTO.SupplierName;
                txtContractPerson.Text = oSupplierInfoDTO.ContractPerson;
                txtShortName.Text = oSupplierInfoDTO.ShortName;
                txtAddress.Text = oSupplierInfoDTO.Address;
                txtPhone.Text = oSupplierInfoDTO.Phone;
                txtFax.Text = oSupplierInfoDTO.Fax;
                txtEmail.Text = oSupplierInfoDTO.Email;
                txtWebAddress.Text = oSupplierInfoDTO.WebAddress;
                this.btnSave.Text = "Update";
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
        //        DataBinder.Eval(e.Row.DataItem, "SupplierCode") + "')");
        //    }
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void txtSupplierName_TextChanged(object sender, EventArgs e)
    {

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
