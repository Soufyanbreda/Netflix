using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Netflix_SoufyanBargach.Startup))]
namespace Netflix_SoufyanBargach
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
