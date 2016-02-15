using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildeezyProject.Startup))]
namespace BuildeezyProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
