using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AAHWebsite.Startup))]
namespace AAHWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
