using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWebStore.Startup))]
namespace GitWebStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
