using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BEPiD2016.Startup))]
namespace BEPiD2016
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
