using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaviApplication.Startup))]
namespace RaviApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
