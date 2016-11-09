using System;
using System.Data;
using System.Configuration;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;


namespace DSL.POS.DTO.Common.DTO
{
    /// <summary>
    /// Summary description for CommonDTO
    /// </summary>
    /// 

    public class CommonDTO
    {
        private Guid _PrimaryKey;
        private string _EntryBy;
        private DateTime _EntryDate;


        public Guid PrimaryKey
        {
            set { _PrimaryKey = value; }
            get { return _PrimaryKey; }

        }

        public string EntryBy
        {
            set { _EntryBy = value; }
            get { return _EntryBy; }

        }
        public DateTime EntryDate
        {
            set { _EntryDate = value; }
            get { return _EntryDate; }

        }



        public CommonDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}