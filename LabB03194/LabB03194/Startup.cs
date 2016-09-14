using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabB03194.Startup))]
namespace LabB03194
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
