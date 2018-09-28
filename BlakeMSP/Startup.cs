using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlakeMSP.Startup))]
namespace BlakeMSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
