using System.Web.Mvc;
using Nop.Web.Framework.Security;
using Nop.Core.Data;
using Nop.Web.Framework.Themes;
using Nop.Services.Tasks;
using Nop.Core.Infrastructure;
using Nop.Core.Domain;
using StackExchange.Profiling.Mvc;
using System;
using Nop.Services.Logging;
using Nop.Core;

namespace Nop.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        [NopHttpsRequirement(SslRequirement.No)]
        public ActionResult Index(string email)
        {
            return View();
        }
    }
}
