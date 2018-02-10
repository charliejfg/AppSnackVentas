using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppVentas.Startup))]
namespace AppVentas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
