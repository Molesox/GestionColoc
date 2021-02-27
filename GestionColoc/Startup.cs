using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionColoc.Startup))]
namespace GestionColoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
