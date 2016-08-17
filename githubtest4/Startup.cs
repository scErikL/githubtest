using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubtest4.Startup))]
namespace githubtest4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
