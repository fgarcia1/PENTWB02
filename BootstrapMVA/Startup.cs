using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapMVA.Startup))]
namespace BootstrapMVA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
