using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperheroCreatorProject.Startup))]
namespace SuperheroCreatorProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
