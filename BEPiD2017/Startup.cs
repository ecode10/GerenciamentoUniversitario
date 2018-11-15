using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BEPiD2017.Startup))]
namespace BEPiD2017
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            //ConfigureAuth(app);
        }
    }
}
