using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MontyTwitter.App.Startup))]
namespace MontyTwitter.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
