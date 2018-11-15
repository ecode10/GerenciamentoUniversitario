using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aluno.bepiducb.com.br.Startup))]
namespace aluno.bepiducb.com.br
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
