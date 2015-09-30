using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyFootball.Startup))]
namespace FantasyFootball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
