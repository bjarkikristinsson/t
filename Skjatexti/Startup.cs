using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skjatexti.Startup))]
namespace Skjatexti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
