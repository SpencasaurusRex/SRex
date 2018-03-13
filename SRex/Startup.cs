using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SRex.Startup))]
namespace SRex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
