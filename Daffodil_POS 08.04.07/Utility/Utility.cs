using System;

using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using DSL.POS.DTO.DTO;
namespace DSL.POS.Common.Utility
{

  public  class Utility
    {


      public void DropDownListFillUp(DropDownList cmb,List<ProductCategoryInfoDTO> ss)
      {
          int i = 0;

          
          cmb.Items.Clear();
          cmb.Items.Add("(Select any category)");

          foreach (ProductCategoryInfoDTO newDto in ss)
          {
              i++;
             
              cmb.Items.Add(newDto.PC_Description);
              cmb.Items[i].Value = newDto.PrimaryKey.ToString();
          }
      }

    }
}
