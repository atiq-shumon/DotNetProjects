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


public partial class MemberInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.txtManualCode.Focus();
        this.txtBirthday.Attributes.Add("onKeyUp", "formatDateField()");
      
        this.txtManualCode.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtName.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtAttention.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtAddress.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtContactPerson.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtPhone.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtMobile.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtFax.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtEmail.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtWebsite.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtBirthday.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtCreditLimit.Attributes.Add("onkeypress", "FocusControl_byEnter()");
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }

        try
        {
            //string showme = txtBirthday.Text;
            MemberInfoDTO  dto = populate();

            Facade facade = Facade.GetInstance();
            IMemberInfoBL oIMemberInfoBL = facade.createMemberBL();
            oIMemberInfoBL.addNewMemberRecord (dto);
            
            this.lblErrorMessage.Text = "Data Save Successfully.";

            this.txtHideFieldPK.Value = "";
            this.txtCode.Text = "";
            this.txtManualCode.Text = "";
            this.txtName.Text = "";
            this.txtAttention.Text = "";
            this.txtContactPerson.Text = "";
            this.txtAddress.Text = "";
            this.txtPhone.Text = "";
            this.txtMobile.Text = "";
            this.txtFax.Text = "";
            this.txtEmail.Text = "";
            this.txtWebsite.Text = "";
            this.txtBirthday.Text = "";
            this.txtCreditLimit.Text = "";
            this.btnSave.Text = "Save";
            this.GridView1.DataBind();
            
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    public MemberInfoDTO populate()
    {
        try
        {
            MemberInfoDTO dto = new MemberInfoDTO();
            
            if (this.txtHideFieldPK.Value != "")
            {
                dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value);
            }

            dto.CustId = this.txtCode.Text;
            dto.ManualId = this.txtManualCode.Text;
            dto.CustName = this.txtName.Text;
            dto.CustAtten = this.txtAttention.Text;
            dto.ContactPerson  = this.txtContactPerson.Text;
            dto.CustAddr = this.txtAddress.Text;
            dto.CustPhone = this.txtPhone.Text;
            dto.Mobile  = this.txtMobile.Text;
            dto.CustFax = this.txtFax.Text;
            dto.CustEmail  = this.txtEmail.Text;
            dto.WebSite  = this.txtWebsite.Text;

            if (this.txtBirthday.Text.Length != 0)
                dto.BirthDay = Convert.ToDateTime(this.txtBirthday.Text);
            else 
                dto.BirthDay =Convert.ToDateTime("01/01/1900");

            if (this.txtCreditLimit.Text.Trim().Length  == 0)
                dto.CreditLimit = 0;
            else
                dto.CreditLimit = (Decimal)TypeDescriptor.GetConverter(dto.CreditLimit).ConvertFromString(this.txtCreditLimit.Text);

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
                MemberInfoDTO dto = new MemberInfoDTO();

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView1.Rows[index];
                
                DataKey xx = this.GridView1.DataKeys[index];
                this.txtHideFieldPK.Value = xx.Value.ToString();

                Facade facade = Facade.GetInstance();
                dto  = facade.getMemberInfo ((Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value));
                this.txtCode.Text = dto.CustId;
                this.txtManualCode.Text=dto.ManualId;
                this.txtName.Text=dto.CustName;
                this.txtAttention.Text=dto.CustAtten;
                this.txtContactPerson.Text=dto.ContactPerson;
                this.txtAddress.Text=dto.CustAddr;
                this.txtPhone.Text=dto.CustPhone;
                this.txtMobile.Text=dto.Mobile;
                this.txtFax.Text=dto.CustFax;
                this.txtEmail.Text=dto.CustEmail;
                this.txtWebsite.Text=dto.WebSite;
                this.txtBirthday.Text = dto.BirthDay.ToString("MM/dd/yyyy");
                this.txtCreditLimit.Text = dto.CreditLimit.ToString();
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
        //        DataBinder.Eval(e.Row.DataItem, "CustID") + "')");
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
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Default.aspx");
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        lblErrorMessage.Text = "Data Deleted Successfully";
    }
}
