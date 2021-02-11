using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarcoAntonioTerragniWeb.Startup))]
namespace MarcoAntonioTerragniWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
