using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoveLib.Startup))]
namespace MoveLib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
