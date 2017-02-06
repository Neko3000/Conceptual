using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conceptual.Startup))]
namespace Conceptual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
