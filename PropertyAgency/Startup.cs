using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyAgency.Startup))]
namespace PropertyAgency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
