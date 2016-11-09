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
using System.Text;
using System.Collections.Generic;
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;

public partial class ui_setup_BranchInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.lblErrorMessage.Text = "";
        this.ddlBranchType.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtBranchName.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtBranchAddress.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtContactPerson.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtContactPersonPhone.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtBranchPrefix .Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtTelephone1.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtTelephone2.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtTelephone3.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtFax.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        this.txtEMail.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        //this.txtCashInSafeLimit.Attributes.Add("onkeypress", "doNumericWithFloat()");
        this.txtCashInSafeLimit.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        if (!IsPostBack)
        {
            try
            {

                Facade facade = Facade.GetInstance();

                DropDownListBrnachType(facade);

                Initilize_Page_Control();
            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }
        }
        else
        {
            //Response.Write("not not");
        }

    }

    private void DropDownListBrnachType(Facade facade)
    {
        IBranchTypeInfoBL  BranchTypeList = facade.createBranchTypeBL();
        List<BranchTypeInfoDTO> oBranchTypeList = BranchTypeList.showDataBranchTypeInfo();


        int i = 0;
        ddlBranchType.Items.Clear();
        ddlBranchType.Items.Add("(Select branch type.)");
        this.ddlBranchType.Items[i].Value = "";
        foreach (BranchTypeInfoDTO  newDto in oBranchTypeList)
        {
            i++;
            this.ddlBranchType.Items.Add(newDto.BT_Name);
            this.ddlBranchType.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //try
        //{
        //    e.Row.ClientID.ToString();
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        Button b = (Button)e.Row.FindControl("Button1");
        //        b.Attributes.Add("onclick", "javascript:return " +
        //        "confirm('Are you sure you want to delete this record " +
        //        DataBinder.Eval(e.Row.DataItem, "BranchCode") + "')");
        //    }
        // }
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
                BranchInfoDTO odto = new BranchInfoDTO();

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                DataKey dk = GridView1.DataKeys[index];
                this.txtBR_PK.Value = dk.Value.ToString();

                Facade facade = Facade.GetInstance();
                odto = facade.getBranchInfoDTO((Guid)TypeDescriptor.GetConverter(odto.PrimaryKey).ConvertFromString(this.txtBR_PK.Value));

                this.txtBranchCode.Text = odto.BranchCode;

                BranchTypeInfoDTO btDto = new BranchTypeInfoDTO();
                btDto = facade.getBranchTypeInfo((Guid)odto.BT_PK);
                if (btDto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000") 
                {
                    this.ddlBranchType.SelectedValue = "";
                }
                else 
                    this.ddlBranchType.SelectedValue = btDto.PrimaryKey.ToString();

                this.txtBranchName.Text = odto.BranchName;
                this.txtContactPerson.Text = odto.ContactPerson;
                this.txtContactPersonPhone.Text = odto.ContactPersonPhone;
                this.txtBranchPrefix.Text = odto.BranchPrefix;
                this.txtBranchAddress.Text = odto.BranchAddress;
                this.txtTelephone1.Text = odto.Telephone1;
                this.txtTelephone2.Text = odto.Telephone2;
                this.txtTelephone3.Text = odto.Telephone3;
                this.txtFax.Text = odto.Fax;
                this.txtEMail.Text = odto.EMail;
                this.txtCashInSafeLimit.Text = odto.CashInSafeLimit.ToString();
                this.btnAdd.Text = "Update";
                this.txtBranchName.Focus();

                //this.Text = Server.HtmlDecode(row.Cells[].Text);

            }
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        this.txtBranchName.Text = "";
        ////GridView1.SelectedRow.Attributes.Add("onclick", "test()");
        //int index = e.RowIndex;
        //GridViewRow row = GridView1.Rows[index];
        //BranchInfoDTO brdto = new BranchInfoDTO();
        //try
        //{
        //    DataKey dk = GridView1.DataKeys[index];
        //    this.txtBR_PK.Value = dk.Value.ToString();
        //    brdto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(brdto.PrimaryKey).ConvertFromString(this.txtBR_PK.Value);

        //    IBranchInfoBL brFacade = Facade.GetInstance().createBranchBL();
        //    brFacade.deleteBranch(brdto);
        //    this.txtBR_PK.Value = "";

        //    GridView1.DataBind();
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
        //finally
        //{

        //    Initilize_Page_Control();
        //}
    }

    protected void GridView1_BeforeEditing(object sender, GridViewEditEventArgs e)
    {

        e.Cancel = true;
        
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }

        if (this.txtBranchName.Text.Length == 0 )
        {
            this.lblErrorMessage.Text = "Branch Name field can not be blank. Please Insert";
            txtBranchName.Focus();
            return;
        }
        
        else if (this.txtBranchAddress.Text.Length == 0)
        {
            this.lblErrorMessage.Text = "Branch Address field can not be blank. Please Insert";
            this.txtBranchAddress.Focus();
            return;
        }
        else if (this.txtCashInSafeLimit.Text.Length == 0 )
        {
            this.lblErrorMessage.Text = "Cash In Safe Limit field can not be blank.You must enter a number.";
            this.txtCashInSafeLimit.Focus();
            return;
        }

        try
        {
            BranchInfoDTO brdto = Populate();

            IBranchInfoBL brFacade = Facade.GetInstance().createBranchBL();
            brFacade.addNewBranch(brdto);
            this.lblErrorMessage.Text = "Data Save Successfully.";
            this.txtBR_PK.Value = "";


            int codeno = 0;
            string num;
            int brcodeno = Convert.ToInt32(brdto.BranchCode);
            codeno = (brcodeno + 1);
            num = codeno.ToString("000");
            GridView1.DataBind();


        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }

        finally
        {
            Initilize_Page_Control();            
        }
   }
   
    private BranchInfoDTO Populate()
    {
        string strBT_PK;
        BranchInfoDTO dto = new BranchInfoDTO();
        if (this.txtBR_PK.Value.ToString() != "")
        { dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtBR_PK.Value); }

        Guid nullGuid = Guid.NewGuid();
        nullGuid = (Guid)TypeDescriptor.GetConverter(nullGuid).ConvertFromString("00000000-0000-0000-0000-000000000000");
            
        strBT_PK = (string)this.ddlBranchType.SelectedValue;
        dto.BT_PK = strBT_PK == string.Empty ? nullGuid : (Guid)TypeDescriptor.GetConverter(dto.BT_PK).ConvertFromString(strBT_PK);
        dto.BranchCode=this.txtBranchCode.Text;
        dto.BranchName=this.txtBranchName.Text ;
        dto.ContactPerson=this.txtContactPerson.Text ;
        dto.ContactPersonPhone=this.txtContactPersonPhone.Text ;
        dto.BranchPrefix=this.txtBranchPrefix.Text ;
        dto.BranchAddress=this.txtBranchAddress.Text ;
        dto.Telephone1=this.txtTelephone1.Text ;
        dto.Telephone2=this.txtTelephone2.Text ;
        dto.Telephone3=this.txtTelephone3.Text ;
        dto.Fax=this.txtFax.Text ;
        dto.EMail=this.txtEMail.Text ;
        
        dto.CashInSafeLimit = (Decimal)TypeDescriptor.GetConverter(dto.CashInSafeLimit).ConvertFromString(this.txtCashInSafeLimit.Text);
        dto.EntryBy = Constants.DEFULT_USER;
        dto.EntryDate = DateTime.Today;
        return dto;
    }

    protected void btnPrint_Click(object sender, EventArgs e)
    {
        Session["PrintGridviewColumns"] = this.GridView1.Columns;
        Session["PrintGridViewDataSource"] = this.ObjectDataSource1.Select();
        //Do some java script to bring up the Printing form in a different browser window
        StringBuilder sb = new StringBuilder();
        sb.Append("<script>");
        sb.Append(Environment.NewLine);
        sb.Append("window.open(\"PrintGridview.aspx\",\"Print\",\"top=5,left=5,scrollbars=yes\");");
        sb.Append(Environment.NewLine);
        sb.Append("</script>");

        ClientScript.RegisterStartupScript(this.GetType(), "print", sb.ToString());
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Default.aspx");
    }

    private void Initilize_Page_Control()
    {
        this.txtBranchCode.Text = "";
        this.ddlBranchType.SelectedValue = "";
        this.txtBranchName.Text = "";
        this.txtContactPerson.Text = "";
        this.txtContactPersonPhone.Text = "";
        this.txtBranchPrefix.Text = "";
        this.txtBranchAddress.Text = "";
        this.txtTelephone1.Text = "";
        this.txtTelephone2.Text = "";
        this.txtTelephone3.Text = "";
        this.txtFax.Text = "";
        this.txtEMail.Text = "";
        this.txtCashInSafeLimit.Text = "";
        this.btnAdd.Text = "Save";
        this.ddlBranchType.Focus();
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        lblErrorMessage.Text = "Data Deleted Successfully";
    }
}
