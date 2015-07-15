using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewPages.Startup))]
namespace ViewPages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
