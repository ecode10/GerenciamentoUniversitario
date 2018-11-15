using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BEPiD.Startup))]
namespace BEPiD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
