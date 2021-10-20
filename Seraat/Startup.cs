using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seraat.Startup))]
namespace Seraat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
