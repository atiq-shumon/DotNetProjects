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

public partial class Admin_Setup_Booth_BoothRegistration : System.Web.UI.Page
{
    ClsErrorHandle cls = new ClsErrorHandle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.IsUserInRole(ConfigurationManager.AppSettings["adminrolename"]))
        {
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx");
        }
        if (!IsPostBack)
        {
            try
            {
                this.chkPermanent.Focus();
                this.chkPermanent.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.chkDemo.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtBoothExpiresDate.Attributes.Add("onkeypress", "FocusControl_byEnter()");
                this.txtBoothExpiresDate.Attributes.Add("onkeypress", "doNumeric()");
                this.ddlBoothNo.Attributes.Add("onkeypress", "FocusControl_byEnter()");

                // Retrieving data in cookies 
                
                if (Request.Cookies["DPOS"] != null)
                {

                    //Banding data in Dropdown List

                    Response.Redirect("~/Admin/Setup/Default.aspx");
                    //string ApplName = "";

                    //if (Request.Cookies["DPOS"]["BoothNo"] != null)
                    //{
                    //    ApplName = Request.Cookies["DPOS"]["BoothNo"];

                    //    if (ApplName.ToString() == "3e3771ea-d7c9-4551-bb68-2ce8eb941ab1")
                    //    {
                    //        //Response.Redirect("http://localhost:3116/Web/Client/Sales/Default.aspx");
                    //        //return;
                    //    }
                    //    Response.Redirect("http://localhost:3116/Web/Client/Sales/Default.aspx");
                    //    return;
                    //}
                }
                else
                    if (User.Identity.Name.ToLower() == "admin")
                    {
                        Facade facade = Facade.GetInstance();

                        DropDownListBoothNo(facade);

                    }
                    else
                    {
                        Response.Redirect("~/Admin/Setup/Booth/BoothErrorPage.aspx");
                        return;
                        
                    }
                                
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

    private void DropDownListBoothNo(Facade facade)
    {

        IBoothInfoBL BoothList = facade.createBoothInfoBL();
        List<BoothInfoDTO> oBoothInfoList = BoothList.showDataBoothInfo();
        
        int i = 0;
        ddlBoothNo.Items.Clear();
        ddlBoothNo.Items.Add("(Select booth No.)");
        this.ddlBoothNo.Items[i].Value = "";
        foreach (BoothInfoDTO newDto in oBoothInfoList)
        {
            i++;
            this.ddlBoothNo.Items.Add(newDto.BoothNo.ToString());
            this.ddlBoothNo.Items[i].Value = newDto.PrimaryKey.ToString();
        }
    }

    
    protected void btnBoothReg_Click(object sender, EventArgs e)
    {
        int permanentDay = 0;
        int demoDay = 0;
        int ExpiresDate = 0;
        
        if ((chkPermanent.Checked == false ) && (chkDemo.Checked == false))
        {
            this.lblErrorMessage.Text = "You must be select Registration Type!";
            return;
        }
        if ((chkPermanent.Checked == true ) && (chkDemo.Checked == true ))
        {
            this.lblErrorMessage.Text = "You must be select one registration Type!";
            return;
        }
        if ((chkPermanent.Checked == true) && (chkDemo.Checked == false) )
        {
             permanentDay = 356;
        }
        if ((chkPermanent.Checked == false ) && (chkDemo.Checked == true))
        {
            if (this.txtBoothExpiresDate.Text == "")
            {
                return;
            }
            demoDay =int.Parse(this.txtBoothExpiresDate.Text);
        }
        if (this.lblErrorMessage.Text.Length != 0)
        {
            this.lblErrorMessage.Text = "";
        }
        

        BoothInfoDTO dto = populate();

        Facade facade = Facade.GetInstance();
        IBoothInfoBL oBoothInfoBL = facade.createBoothInfoBL();
        oBoothInfoBL.addNewBoothRecord(dto);

        
        // Get values in text field
        string boothNo = this.ddlBoothNo.SelectedValue;

        if( permanentDay != 0 )
        {
            ExpiresDate = permanentDay;
        }    
        else 
            ExpiresDate = demoDay;

        
        
        DateTime dt = DateTime.Now;
        TimeSpan ts = new TimeSpan(0, ExpiresDate, 0, 0);

        //Create a custome coookies
        HttpCookie myCookie = new HttpCookie("DPOS");

        //Keep data in cookies
        //myCookie["BoothNo"] = "ONE";
        myCookie["BoothNo"] = boothNo;
        myCookie.Expires = dt.Add(ts);
        Response.Cookies.Add(myCookie);
        

        this.lblErrorMessage.Text = "Booth Registration Successfully.";
        this.ddlBoothNo.SelectedValue = "";
        //this.pnlDay.Visible = false;
        this.txtHideFieldPK.Value = "";
        this.chkPermanent.Checked = false;
        this.chkDemo.Checked = false;
        
    }

    private BoothInfoDTO populate()
    {

        try
        {
            short  intBoothNo = 0;
            BoothInfoDTO dto = new BoothInfoDTO();
            // populate dto
                     
            Facade facade = Facade.GetInstance();

            // PK keep in local variable 
            intBoothNo =Convert.ToInt16 ( ddlBoothNo.SelectedItem.Text);
            
            //  Get the Booth Information Corresponding Booth No. and keep Booth Info Domain Object
            dto = facade.getBoothInfoByCodeDTO(intBoothNo);
           
            // set up the member primary code in local declared Hidden field
            this.txtHideFieldPK.Value = dto.PrimaryKey.ToString();
                                    
            dto.EntryBy = "Admin";
            dto.EntryDate = DateTime.Now.Date;
            return dto;
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
    }

}
