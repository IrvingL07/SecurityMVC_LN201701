using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSecurityDemo_LN201701.Startup))]
namespace MVCSecurityDemo_LN201701
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
