using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MulticluehnSolution.Web.Startup))]
namespace MulticluehnSolution.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
