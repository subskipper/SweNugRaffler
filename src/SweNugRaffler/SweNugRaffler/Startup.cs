using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SweNugRaffler.Startup))]
namespace SweNugRaffler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
