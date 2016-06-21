using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploGit.Startup))]
namespace EjemploGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
