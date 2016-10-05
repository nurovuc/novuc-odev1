using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(odev1.Startup))]
namespace odev1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
