using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFoad2024_2.Startup))]
namespace MvcFoad2024_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
