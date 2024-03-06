using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UABC.Startup))]
namespace UABC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
