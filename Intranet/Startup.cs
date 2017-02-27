using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Intranet.Startup))]
namespace Intranet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
