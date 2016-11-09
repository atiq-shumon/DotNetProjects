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
using DSL.POS.Facade;
using DSL.POS.DTO.DTO;
using DSL.POS.BusinessLogicLayer.Interface;
using DSL.POS.Common.Utility;

    public partial class ui_setup_BranchTypeInfo : System.Web.UI.Page
    {
     
        ClsErrorHandle cls = new ClsErrorHandle();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
            {
                Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
            }
            this.lblErrorMessage.Text = "";
            this.txtBT_Name.Focus();
            txtBT_Name.Attributes.Add("onkeypress", "FocusControl_byEnter()");
            //ControlState_Refresh();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.lblErrorMessage.Text.Length != 0)
            {
                this.lblErrorMessage.Text = "";
            }

            if (this.txtBT_Name.Text.Length == 0)
            {
                this.lblErrorMessage.Text = "Branch type name field can not be blank.";
                this.txtBT_Name.Focus();
                return;
            }

            BranchTypeInfoDTO btdto = Populate();

            try
            {

                Facade facade = Facade.GetInstance();
                IBranchTypeInfoBL oBranchTypeInfoBL = facade.createBranchTypeBL();
                oBranchTypeInfoBL.addNewBranchTypeRecord(btdto);
                this.lblErrorMessage.Text = "Data Save Successfully.";
            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }
            GridView1.DataBind();
            ControlState_Refresh();
        }

        private BranchTypeInfoDTO Populate()
        {
            try
            {
                BranchTypeInfoDTO dto = new BranchTypeInfoDTO();

                if (this.txtBT_PK.Value.ToString() != "")
                {
                    dto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(dto.PrimaryKey).ConvertFromString(this.txtBT_PK.Value);
                }


                dto.BT_Code = this.txtBT_Code.Text;
                dto.BT_Name = this.txtBT_Name.Text;
                dto.EntryBy = Constants.DEFULT_USER;
                dto.EntryDate = DateTime.Today;

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
            //        DataBinder.Eval(e.Row.DataItem, "BT_Code") + "')");
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
                    BranchTypeInfoDTO oBranchTypeInfoDTO = new BranchTypeInfoDTO();

                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = this.GridView1.Rows[index];

                    this.txtBT_Name.Text = Server.HtmlDecode(row.Cells[2].Text);

                    //this.Text = Server.HtmlDecode(row.Cells[].Text);
                    DataKey dk = this.GridView1.DataKeys[index];
                    this.txtBT_PK.Value = dk.Value.ToString();

                    Facade facade = Facade.GetInstance();
                    oBranchTypeInfoDTO = facade.getBranchTypeInfo((Guid)TypeDescriptor.GetConverter(oBranchTypeInfoDTO.PrimaryKey).ConvertFromString(this.txtBT_PK.Value));

                    this.txtBT_Code.Text = oBranchTypeInfoDTO.BT_Code;
                    this.txtBT_Name.Text = oBranchTypeInfoDTO.BT_Name;
                    this.btnAdd.Text = "Update";
                    this.txtBT_Name.Focus();
                }
            }
            catch (Exception Exp)
            {
                lblErrorMessage.Text = cls.ErrorString(Exp);
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //int index = e.RowIndex;
            //GridViewRow row = GridView1.Rows[index];

            //BranchTypeInfoDTO btdto = new BranchTypeInfoDTO();

            //DataKey dk = this.GridView1.DataKeys[index];
            //this.txtBT_PK.Value = dk.Value.ToString();
            //btdto.PrimaryKey = (Guid)TypeDescriptor.GetConverter(btdto.PrimaryKey).ConvertFromString(this.txtBT_PK.Value);

            //try
            //{
            //    Facade facade = Facade.GetInstance();
            //    IBranchTypeInfoBL brFacade = facade.createBranchTypeBL();
            //    brFacade.deleteBranchTypeRecord(btdto);
            //}
            //catch (Exception Exp)
            //{
            //    lblErrorMessage.Text = cls.ErrorString(Exp);

            //}

            //this.txtBT_PK.Value = "";
            //GridView1.DataBind();
            //ControlState_Refresh();
        }

        protected void GridView1_BeforeEditing(object sender, GridViewEditEventArgs e)
        {
            e.Cancel = true;
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Default.aspx");
        }

        private void ControlState_Refresh()
        {
            if (this.lblErrorMessage.Text.Length != 0)
            {
                this.lblErrorMessage.Text = "";
            }

            this.txtBT_Code.Text = "";
            this.txtBT_PK.Value = "";
            this.txtBT_Name.Text = "";
            this.btnAdd.Text = "Save";
            this.txtBT_Name.Focus();

        }
        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            lblErrorMessage.Text = "Data Deleted Successfully";
        }
}
