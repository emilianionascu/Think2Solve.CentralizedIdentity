using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Think2Solve.CentralizedIdentity.Web.Startup))]
namespace Think2Solve.CentralizedIdentity.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
