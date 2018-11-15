using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admin.bepiducb.com.br.Startup))]
namespace admin.bepiducb.com.br
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
