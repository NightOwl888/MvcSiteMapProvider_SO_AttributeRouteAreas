using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SO_AttributeRouteAreas.Startup))]
namespace SO_AttributeRouteAreas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
