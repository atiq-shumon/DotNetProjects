using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace DSL.Common.Security
{
    /// <summary>
    /// Summary description for UserInfoDTO
    /// </summary>
    public class UserInfoDTO
    {
        protected Guid _id;
        protected string _userName = String.Empty;
        protected string _uPassword = String.Empty;
        protected int _passwordFormat;
        protected string _passwordSalt = String.Empty;
        protected DateTime _lastLoginDate;
        protected DateTime _lastPasswordChangedDate;
        protected DateTime _createDate;
        protected Guid _createdby = Guid.Empty;

        #region Public Properties
        public Guid UserID
        {
            get { return _id; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _uPassword; }
            set { _uPassword = value; }
        }

        public int PasswordFormat
        {
            get { return _passwordFormat; }
            set { _passwordFormat = value; }
        }

        public string PasswordSalt
        {
            get { return _passwordSalt; }
            set { _passwordSalt = value; }
        }

        public DateTime LastLoginDate
        {
            get { return _lastLoginDate; }
            set { _lastLoginDate = value; }
        }

        public DateTime LastPasswordChangedDate
        {
            get { return _lastPasswordChangedDate; }
            set { _lastPasswordChangedDate = value; }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        public Guid Createdby
        {
            get { return _createdby; }
            set { _createdby = value; }
        }

        #endregion


        public UserInfoDTO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}