using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormFoad2024.Startup))]
namespace WebFormFoad2024
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
