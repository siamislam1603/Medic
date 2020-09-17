using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medic.Startup))]
namespace Medic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
