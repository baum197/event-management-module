using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventManagementModule.Startup))]
namespace EventManagementModule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
