using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scorer.Mobile.Startup))]
namespace Scorer.Mobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
