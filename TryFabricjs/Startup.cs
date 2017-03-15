using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryFabricjs.Startup))]
namespace TryFabricjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
