using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonTaskApp.Startup))]
namespace PersonTaskApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
