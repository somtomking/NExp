using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NExp.Web.Startup))]
namespace NExp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
