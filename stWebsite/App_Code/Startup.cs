using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stWebsite.Startup))]
namespace stWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
