using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Everton_teste.Startup))]
namespace Everton_teste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
