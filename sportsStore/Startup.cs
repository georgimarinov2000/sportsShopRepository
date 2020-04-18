using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sportsStore.Startup))]
namespace sportsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
