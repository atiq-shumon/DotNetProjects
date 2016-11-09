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
using System.Collections.Generic;
using DSL.POS.Common.Utility; 
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;


public partial class ui_setup_BoothInfo : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        this.ddlBranchName.Focus();
        ddlBranchName.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        txtCashLimit.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        chkBoothStatus.Attributes.Add("onkeypress", "FocusControl_byEnter()");
        if (!IsPostBack)
        {
            try
            {
                Facade facade = Facade.GetInstance();
                DropDownListBrnachName(facade);
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

    private void DropDownListBrnachName(Facade facade)
    {
        IBranchInfoBL BranchList = facade.createBranchBL();
        List<BranchInfoDTO> oBranchList = BranchList.GetBranchInfo();
        
        int i = 0;
        ddlBranchName.Items.Clear();
        ddlBranchName.Items.Add("(Select branch name)");
        this.ddlBranchName.Items[i].Value = "";
        foreach (BranchInfoDTO newDto in oBranchList)
        {
            i++;
            this.ddlBranchName.Items.Add(newDto.BranchName);
            this.ddlBranchName.Items[i].Value = newDto.PrimaryKey.ToString();
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

            BoothInfoDTO dto = populate();

            Facade facade = Facade.GetInstance();
            IBoothInfoBL oBoothInfoBL = facade.createBoothInfoBL();
            oBoothInfoBL.addNewBoothRecord(dto);
           
            this.lblErrorMessage.Text = "Data Save Successfully.";
            
            this.ddlBranchName.SelectedValue = "";
            this.txtHideFieldPK.Value = "";
            this.txtCashLimit.Text = "";
            this.chkBoothStatus.Checked = true;
            this.btnSave.Text = "Save";
            this.GridView1.DataBind();
        }
        catch (Exception Exp)
        {
            lblErrorMessage.Text = cls.ErrorString(Exp);
        }
    }

    public BoothInfoDTO populate()
    {
        try
        {
            string strPC_PK;
            BoothInfoDTO dto = new BoothInfoDTO();
            // populate dto


            if (this.txtHideFieldPK.Value != "")
            {
                dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value);
            }

            Guid nullGuid = Guid.NewGuid();
            nullGuid = (Guid)TypeDescriptor.GetConverter(nullGuid).ConvertFromString("00000000-0000-0000-0000-000000000000");
            
            strPC_PK = (string)this.ddlBranchName.SelectedValue;
            dto.BR_PK = strPC_PK == string.Empty ? nullGuid : (Guid)TypeDescriptor.GetConverter(dto.BR_PK).ConvertFromString(strPC_PK);
            dto.BoothCashLimit = this.txtCashLimit.Text == string.Empty ? 0 : (Decimal)TypeDescriptor.GetConverter(dto.BoothCashLimit).ConvertFromString(this.txtCashLimit.Text);
            dto.BoothStatus = this.chkBoothStatus.Checked;

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
                BoothInfoDTO oBoothInfoDTO = new BoothInfoDTO();

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView1.Rows[index];

                DataKey xx = this.GridView1.DataKeys[index];
                this.txtHideFieldPK.Value = xx.Value.ToString();

                Facade facade = Facade.GetInstance();
                oBoothInfoDTO = facade.getBoothInfoDTO((Guid)TypeDescriptor.GetConverter(oBoothInfoDTO.PrimaryKey).ConvertFromString(this.txtHideFieldPK.Value));
                this.txtCashLimit.Text = oBoothInfoDTO.BoothCashLimit.ToString();
                this.chkBoothStatus.Checked = oBoothInfoDTO.BoothStatus;

                BranchInfoDTO bDto = new BranchInfoDTO ();
                bDto = facade.getBranchInfoDTO((Guid)oBoothInfoDTO.BR_PK);
                if (bDto.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    this.ddlBranchName.SelectedValue = "";
                }
                else 
                    this.ddlBranchName.SelectedValue = bDto.PrimaryKey.ToString();
                this.lblErrorMessage.Text = "";
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
        //        DataBinder.Eval(e.Row.DataItem, "BoothNo") + "')");
        //    }
        //}
        //catch (Exception Exp)
        //{
        //    lblErrorMessage.Text = cls.ErrorString(Exp);
        //}
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        this.ddlBranchName.SelectedValue = "";
        this.txtCashLimit.Text = "";
        this.chkBoothStatus.Checked = true;

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Default.aspx");
    }


    protected void ddlBranchName_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }
    }
    protected void txtCashLimit_TextChanged(object sender, EventArgs e)
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
