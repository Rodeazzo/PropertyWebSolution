using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyWebApplication.Startup))]
namespace PropertyWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
