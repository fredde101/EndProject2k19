using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlutProjekt2k19.Startup))]
namespace SlutProjekt2k19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
