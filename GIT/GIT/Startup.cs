using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIT.Startup))]
namespace GIT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
